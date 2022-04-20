using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalse
{
    public partial class MainPage : ContentPage
    {
        private IList<string> questionList = new List<string>() {"Thursday was once known as Thors Day","Cats have nine lives", "Dogs can't look up" };
        private IList<Boolean> answerList = new List<Boolean>() {true, false, false};
        private int Index = 0;
        private int CountCorrect = 0;
        
        public MainPage()
        {
            InitializeComponent();
            Questions.Text = questionList[Index];

        }

        void True(object sender, EventArgs e)
        {
            if (answerList[Index++] == true) CountCorrect++;
            if (Index < questionList.Count)
            {
                Questions.Text = questionList[Index];
            }
            else
            {
                True_Button.IsVisible = false;
                False_Button.IsVisible = false;
                Questions.Text = $"Correctly Answered: {CountCorrect}";
            }

        }

        void False(object sender, EventArgs e)
        {
            if (answerList[Index++] == false) CountCorrect++;
            if (Index < questionList.Count)
            {
                Questions.Text = questionList[Index];
            }            
            else
            {
                True_Button.IsVisible = false;
                False_Button.IsVisible = false;
                Questions.Text = $"Correctly Answered: {CountCorrect}";
            }


        }



        
    }
}