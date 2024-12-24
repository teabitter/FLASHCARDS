using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLASHCARDS
{
    public partial class Application : Form
    {
        private List<Flashcard> flashcards = new List<Flashcard>();
        private int currentCardIndex;
        public Application()
        {
            InitializeComponent();
            //IntializeFlashcards();
            //ShowCurrentFlashcard();
        }

       
        private void buttonNext_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text.Trim();
            string answer = textBoxAnswer.Text.Trim();

            if (!string.IsNullOrEmpty(question) && !string.IsNullOrEmpty(answer))
            {
                Flashcard newFlashcard = new Flashcard(question, answer);
                flashcards.Add(newFlashcard);
                UpdateFlashcardList();
            }
            else
            {
                MessageBox.Show("Enter a question and an answer.");
            }
        }

        private void UpdateFlashcardList()
        {
            listBoxFlashcards.Items.Clear();
            
            foreach(Flashcard flashcard in flashcards)
            {
                listBoxFlashcards.Items.Add(flashcard.Question);
            }
        }

        private void listBoxFlashcards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxFlashcards.SelectedIndex >= 0)
            {
                Flashcard selectedFlashcard = flashcards[listBoxFlashcards.SelectedIndex];
                textBoxQuestion.Text = selectedFlashcard.Question;
                textBoxAnswer.Text = selectedFlashcard.Answer;
            }
        }
    }
}
