using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public List<Test> tests = new List<Test>();
        string pathToFile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Відкрити файл з питаннями";
            theDialog.Filter = "TXT files|*.txt";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFile = theDialog.FileName;
            }

            if (File.Exists(pathToFile))
            {
                string text;
                using (StreamReader sr = new StreamReader(pathToFile, Encoding.GetEncoding("UTF-8")))
                {
                    text = sr.ReadToEnd();
                    tb_openedFile.Text = text;
                    tb_fileName.Text = Path.GetFileName(pathToFile);
                    SplitTests(text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                }
            }
        }
         
        private void SplitTests(string[] text)
        {
            tests.Clear();
            string question = "";
            List<string> answerVariants = new List<string>();

            string last = text[text.Length - 1];
            for(int i = 0; i < text.Length; i++)
            {
                string s = text[i];
                if (char.IsDigit(s[0]) || i == text.Length - 1)
                {
                    if(s == last)
                    {
                        answerVariants.Add(s);
                    }

                    if (!string.IsNullOrEmpty(question))
                    {
                        tests.Add(new Test(question, answerVariants));
                        answerVariants.Clear();
                    }

                    question = new Regex(@"^\d+\.?\s*").Replace(s, "");
                }
                else
                {
                    answerVariants.Add(s);
                }
            }
            tb_testCountInFile.Text = tests.Count.ToString();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_variantsCount.Text) || string.IsNullOrEmpty(tb_testCountInVariant.Text))
            {
                MessageBox.Show("Введіть кількість варіантів і кількість питань у кожному варіанті.");
                return;
            }

            if (string.IsNullOrEmpty(tb_fileName.Text) || string.IsNullOrEmpty(tb_testCountInFile.Text))
            {
                MessageBox.Show("Оберіть файл.");
                return;
            }

            if (int.Parse(tb_testCountInFile.Text) < int.Parse(tb_testCountInVariant.Text))
            {
                MessageBox.Show("Загальна кількість тестів менша, ніж бажана кількість тестів у варіанті.");
                return;
            }

            Random rnd = new Random();
            int variantsCount = int.Parse(tb_variantsCount.Text);
            int testsInVariant = int.Parse(tb_testCountInVariant.Text);
            int testsCount = int.Parse(tb_testCountInFile.Text);

            List<Variant> variants = new List<Variant>();
            HashSet<string> usedQuestions = new HashSet<string>();
            for (int i = 0; i < variantsCount; i++)
            {
                Variant variant = new Variant(i);
                List<string> questions = variant.tests.ConvertAll<string>(test => test.question);
                while (variant.tests.Count != testsInVariant)
                {
                    int index = rnd.Next(testsCount);
                    string question = tests.ElementAt(index).question;
                    if (!variant.tests.ConvertAll<string>(test => test.question).Contains(question) && (!usedQuestions.Contains(question) || usedQuestions.Count == testsCount))
                    {
                        variant.tests.Add(tests.ElementAt(index));
                        usedQuestions.Add(question);
                    }
                }
                variants.Add(variant);
            }
            WriteToFile(variants);
        }

        private void WriteToFile(List<Variant> variants)
        {
            string[] letters = { "A", "Б", "В", "Г", "Д", "Е", "Є", "Ж", "З", "И", "І", "Ї", "К", "Л", "М", "Н", "О" };
            string pathVariants = Path.GetDirectoryName(Application.ExecutablePath) + "\\Варіанти.txt";
            string pathAnswers = Path.GetDirectoryName(Application.ExecutablePath) + "\\Відповіді.txt";
            int index = 1;
            while (File.Exists(pathVariants))
            {
                pathVariants = Path.GetDirectoryName(Application.ExecutablePath) + "\\Варіанти" + index + ".txt";
                pathAnswers = Path.GetDirectoryName(Application.ExecutablePath) + "\\Відповіді" + index + ".txt";
                index++;
            }
            using (TextWriter twVariants = new StreamWriter(pathVariants))
            {
                using (TextWriter twAnswers = new StreamWriter(pathAnswers))
                {
                    foreach (Variant variant in variants)
                    {
                        twVariants.WriteLine("Варіант " + (variant.number + 1));
                        twAnswers.WriteLine("Варіант " + (variant.number + 1));
                        for(int i = 0; i < variant.tests.Count; i++)
                        {
                            Test test = variant.tests.ElementAt(i);
                            twVariants.WriteLine((i + 1) + "." + test.question);
                            List<string> shuffledAnswers = test.answers.OrderBy(a => Guid.NewGuid()).ToList();
                            for (int j = 0; j < test.answers.Count; j++)
                            {
                                if(new Regex(@"^[\p{Ll}\p{Lt}]\)").IsMatch(shuffledAnswers.ElementAt(j)))
                                {
                                    twAnswers.WriteLine((i + 1) + ". " + letters[j]);
                                }

                                string answer = new Regex(@"^[\p{Ll}\p{Lt}]\)?\.?\s*").Replace(shuffledAnswers.ElementAt(j), "");
                                twVariants.WriteLine("  " + letters[j] + ". " + answer);
                            }
                        }
                        twVariants.WriteLine();
                        twAnswers.WriteLine();
                    }
                }
            }
            MessageBox.Show("Збережено за шляхом " + pathVariants);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила користування\n" +
                "1. Завантажуйте файли з тестами у форматі .txt та з кодуванням UTF-8.\n" +
                "2. Питання починайте з нового рядка та нумеруйте цифрами:\n  1. Ваше питання.\n" +
                "3. Варіанти відповідей починайте з нового рядка та позначайте буквами:\n  а. Ваш варіант відповіді.\n" +
                "4. Правильні відповіді позначайте за допомогою дужки:\n  б). Це правильна відповідь.\n" +
                "Щасти!");
        }
    }

    public class Variant
    {
        public int number;
        public List<Test> tests;

        public Variant(int variantNumber)
        {
            number = variantNumber;
            tests = new List<Test>();
        }
    }

    public class Test
    {
        public string question;
        public List<string> answers;

        public Test(string quest, List<string> answs)
        {
            question = quest;
            answers = new List<string>(answs);
        }
    }
}

