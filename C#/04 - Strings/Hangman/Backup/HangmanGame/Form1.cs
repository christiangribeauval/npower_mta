using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //=====================================================================
        //THE FOUR VARIABLES BELOW ARE AVAILBLE TO ALL BUTTONS AND METHODS
        //=====================================================================

        private string tbWord;                  //HOLDS THE WORD FROM TEXTBOX
        string[] wordList = new string[10];     //WORD ARRAY
        int advanceCounter = 0;                 //USED TO GET THE NEXT WORD
        string newWord;                         //STORE THE NEW WORD


        //=====================================================================
        //      THE FORM_LOAD EVENT FILLS THE WORDLIST ARRAY WHEN THE FORM LOADS
        //      NOTICE THAT A METHOD CALLED disableLetters IS CALLED
        //=====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            wordList[0] = "Cat";
            wordList[1] = "Mat";
            wordList[2] = "Hat";
            wordList[3] = "Bat";
            wordList[4] = "Sat";
            wordList[5] = "Tat";
            wordList[6] = "Fat";
            wordList[7] = "Pat";
            wordList[8] = "Rat";
            wordList[9] = "Vat";

            disableLetters();
        }

        //=====================================================================
        //      WHEN THE FORM LOADS, SWITCH OFF ALL THE LETTER BUTTONS
        //      THE ONLY BUTTON AVAILABLE WILL BE THE NEW WORD BUTTON
        //=====================================================================
        void disableLetters()
        {
            letterA.Enabled = false;
            letterB.Enabled = false;
            letterC.Enabled = false;
            letterD.Enabled = false;
            letterE.Enabled = false;
            letterF.Enabled = false;
            letterG.Enabled = false;
            letterH.Enabled = false;
            letterI.Enabled = false;
            letterJ.Enabled = false;
            letterK.Enabled = false;
            letterL.Enabled = false;
            letterM.Enabled = false;
            letterN.Enabled = false;
            letterO.Enabled = false;
            letterP.Enabled = false;
            letterQ.Enabled = false;
            letterR.Enabled = false;
            letterS.Enabled = false;
            letterT.Enabled = false;
            letterU.Enabled = false;
            letterV.Enabled = false;
            letterW.Enabled = false;
            letterX.Enabled = false;
            letterY.Enabled = false;
            letterZ.Enabled = false;
        }


        //==============================================================================
        //              THE NEW WORD BUTTON
        //      AS ITS NAME SUGGEST, THIS BUTTON GETS A NEW WORD FROM THE ARRAY
        //      THIS BUTTON ALSO DOES THE FOLOWING
        //              - ADVANCES THE COUNTER FOR THE ARRAY
        //              - ENABLES ALL THE LETTER BUTTONS
        //              - SETS THE NUMBER OF GUESSES A PLAYER HAS
        //              - PUTS 3 * SYMBOLS IN THE TEXTBOX (CHANGE THIS FOR THE EXERCISE!
        //===============================================================================
        private void getNewWord_Click(object sender, EventArgs e)
        {
            if (advanceCounter > 9)
            {
                advanceCounter = 0;
            }
            newWord = wordList[advanceCounter];     //GET A NEW WORD
            MessageBox.Show(newWord);
            advanceCounter++;                       //ADVANCE THE COUNTER FOR THE ARRAY

            enableLetters();                        //ENABLE ALL THE LETTER BUTTONS
            getNewWord.Enabled = false;
            textBox3.Text = "3";                    //SET THE NUMBER OF GUESSES
            textBox2.Text = "***";                  //PUTS 3 * SYMBOLS IN THE TEXTBOX
        }


        //=================================================================================
        //                      THE LETTER BUTTONS
        //      WHEN A LETTER BUTTON IS CLICKED, THE METHOD checkGuessedLetter() IS CALLED
        //      THE METHOD TAKES THE FOLLOWING 3 ARGUEMENTS:
        //                  - THE WORD THAT THE PLAYER IS TRYING TO GUESS
        //                  - THE LETTER THAT THE PLAYER CLICKED ON
        //                  - THE LETTER BUTTON ITSELF (letterA, letterB, letterC, etc)
        //      (When you pass a button object, you can then access its properties.
        //       All we want to do is turn off a button when that letter is guessed.)

        //          SCROLL DOWN TO SEE HOW THE checkGuessedLetter() METHOD WORKS
        //=================================================================================

        private void letterA_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterA.Text, letterA);
        }

        private void letterT_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterT.Text, letterT);
        }

        private void letterC_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterC.Text, letterC);
        }

        private void letterV_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterV.Text, letterV);
        }

        private void letterY_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterY.Text, letterY);
        }

        private void letterZ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterZ.Text, letterZ);
        }

        private void letterB_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterB.Text, letterB);
        }

        private void letterD_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterD.Text, letterD);
        }

        private void letterE_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterE.Text, letterE);
        }

        private void letterF_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterF.Text, letterF);
        }

        private void letterG_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterG.Text, letterG);
        }

        private void letterH_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterH.Text, letterH);
        }

        private void letterI_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterI.Text, letterI);
        }

        private void letterJ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterJ.Text, letterJ);
        }

        private void letterK_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterK.Text, letterK);
        }

        private void letterL_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterL.Text, letterL);
        }

        private void letterM_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterM.Text, letterM);
        }

        private void letterN_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterN.Text, letterN);
        }

        private void letterO_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterO.Text, letterO);
        }

        private void letterP_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterP.Text, letterP);
        }

        private void letterQ_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterQ.Text, letterQ);
        }

        private void letterR_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterR.Text, letterR);
        }

        private void letterS_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterS.Text, letterS);
        }

        private void letterU_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterU.Text, letterU);
        }

        private void letterW_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterW.Text, letterW);
        }

        private void letterX_Click(object sender, EventArgs e)
        {
            checkGuessedLetter(newWord.ToUpper(), letterX.Text, letterX);
        }




        //==========================================================================================
        //      THIS METHOD DOES ALL THE WORK IN THE PROGRAMME. IT'S ACTUALLY A BIT TOO LONG AND
        //      TRIES TO DO TOO MANY THINGS. IT'S REALLY A FEW DIFFERENT METHODS IN ONE!
        //==========================================================================================

        private void checkGuessedLetter(string wordToGuess, string guessedLetter, Button butName)
        {
            tbWord = textBox2.Text;                //GET THE TEXT THAT'S CURRENTLY IN THE WORD TEXTBOX

            int strLen = wordToGuess.Length;        //USE THE LENGTH PROPERTY OF THE wordToGuess STRING

            int guessesLeft = int.Parse(textBox3.Text); //SEE HOW MANY GUESSES A PLAYER HAS LEFT
 
            int result = 0;
            int counter = 0;
            int foundLen = 0;
            string newChar = "";
            int guessedCorrectlyCounter = 0;

            //==========================================================================
            //          THIS LOOP IS USED TO GRAB CHARACTERS FROM THE WORD TO BE GUESSED
            //          WE THEN COMPARE THE LETTER GUESSED TO SEE IF IT IS IN THE WORD
            //          NOTE THE USE OF THE FOLLOWING STRING METHODS:
            //                  -IndexOf()
            //                  -Substring
            //                  -Remove
            //                  -Insert
            //==========================================================================
            for (int i = 0; i < strLen; i++)
            {
                result = wordToGuess.IndexOf(guessedLetter, foundLen, strLen - foundLen);

                if (result != -1)
                {
                    foundLen = result + 1;
                    counter++;

                    newChar = wordToGuess.Substring((result), 1);   //grab the letter to be replaced

                    tbWord = tbWord.Remove(result, 1);              //Remove the * character at this position

                    tbWord = tbWord.Insert(result, newChar);        //insert the new character
                    guessedCorrectlyCounter++;
                }
            }

            //=================================================
            //          CHECK THE NUMBER OF GUESSES LEFT
            //=================================================
            if (guessedCorrectlyCounter == 0)
            {
                guessesLeft = guessesLeft - 1;
                textBox3.Text = guessesLeft.ToString();
            }

            //=================================================
            //          CHECK HOW MANY GUESSESS LEFT. 
            //          IF ZERO - GAME OVER, AND RESET
            //=================================================
            if (guessesLeft == 0)
            {
                MessageBox.Show("You Lost. The word was " + wordToGuess);
                disableLetters();
                getNewWord.Enabled = true;
            }
            else
            {
                //PLACE THE NEW VERSION OF THE WORD BACK INTO THE TEXTBOX
                textBox2.Text = tbWord;

                if (tbWord == wordToGuess)      //CHECK IF PLAYER HAS WON
                {
                    MessageBox.Show("You Won - Well Done!");
                    disableLetters();
                    getNewWord.Enabled = true;
                }

            }

            //=================================================================================
            //      THIS IS WHERE WE USE THE BUTTON OBJECT THAT WE PASSED OVER TO THE METHOD.
            //      ALL WE'RE DOING IS SWITCHING THE LETTER BUTTON OFF
            //=================================================================================
            butName.Enabled = false;        
        }



        //==========================================================================
        //      THIS METHOD ENABLES ALL THE LETTER BUTTONS AT THE START OF THE GAME
        //==========================================================================
        void enableLetters()
        {
            letterA.Enabled = true;
            letterB.Enabled = true;
            letterC.Enabled = true;
            letterD.Enabled = true;
            letterE.Enabled = true;
            letterF.Enabled = true;
            letterG.Enabled = true;
            letterH.Enabled = true;
            letterI.Enabled = true;
            letterJ.Enabled = true;
            letterK.Enabled = true;
            letterL.Enabled = true;
            letterM.Enabled = true;
            letterN.Enabled = true;
            letterO.Enabled = true;
            letterP.Enabled = true;
            letterQ.Enabled = true;
            letterR.Enabled = true;
            letterS.Enabled = true;
            letterT.Enabled = true;
            letterU.Enabled = true;
            letterV.Enabled = true;
            letterW.Enabled = true;
            letterX.Enabled = true;
            letterY.Enabled = true;
            letterZ.Enabled = true;

        }


    }
}