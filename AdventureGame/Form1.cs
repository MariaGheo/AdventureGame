using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracks what page of the story the player is at
        int page = 1;

        //tracks no's
        int noTracker = 0;

        //tracks whether the water bottle is acquired
        bool waterBottle = false;

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            option3Button.Text = "";
            option3Button.Enabled = false;

            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //choose next page
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                if (noTracker != 9)
                {
                    page = 3;
                }
                else
                {
                    page = 12;
                }
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                waterBottle = true;
                page = 15;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 199;
            }
            else if (page == 12)
            {
                page = 5;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 23)
            {
                page = 31;
            }
            else if (page == 24)
            {
                page = 27;
            }
            else if (page == 25)
            {
                page = 29;
            }
            else if (page == 26)
            {
                page = 31;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 199;
            }
            else if (page == 29)
            {
                //50% chance that it's a student or a creature
                int chance = randGen.Next(1, 3);
                if (chance == 1)
                {
                    page = 37;
                }
                else
                {
                    page = 39;
                }
            }
            else if (page == 30)
            {
                page = 33;
            }
            else if (page == 31)
            {
                page = 34;
            }
            else if (page == 32)
            {
                page = 35;
            }
            else if (page == 33)
            {
                page = 199;
            }
            else if (page == 34)
            {
                page = 36;
            }
            else if (page == 35)
            {
                page = 199;
            }
            else if (page == 36)
            {
                page = 47;
            }
            else if (page == 37)
            {
                page = 199;
            }
            else if (page == 38)
            {
                page = 199;
            }
            else if (page == 39)
            {
                page = 43;
            }
            else if (page == 40)
            {
                page = 44;
            }
            else if (page == 41)
            {
                page = 49;
            }
            else if (page == 42)
            {
                page = 50;
            }
            else if (page == 43)
            {
                page = 51;
            }
            else if (page == 44)
            {
                page = 52;
            }
            else if (page == 45)
            {
                page = 53;
            }
            else if (page == 46)
            {
                page = 54;
            }
            else if (page == 47)
            {
                page = 61;
            }
            else if (page == 48)
            {
                page = 55;
            }
            else if (page == 49)
            {
                page = 56;
            }
            else if (page == 50)
            {
                page = 199;
            }
            else if (page == 51)
            {
                page = 199;
            }
            else if (page == 52)
            {
                page = 57;
            }
            else if (page == 53)
            {
                page = 58;
            }
            else if (page == 54)
            {
                page = 69;
            }
            else if (page == 55)
            {
                page = 59;
            }
            else if (page == 56)
            {
                page = 60;
            }
            else if (page == 57)
            {
                page = 69;
            }
            else if (page == 58)
            {
                page = 69;
            }
            else if (page == 59)
            {
                page = 66;
            }
            else if (page == 60)
            {
                page = 65;
            }
            else if (page == 61)
            {
                page = 63;
            }
            else if (page == 62)
            {
                page = 63;
            }
            else if (page == 63)
            {
                page = 199;
            }
            else if (page == 65)
            {
                page = 68;
            }
            else if (page == 66)
            {
                page = 71;
            }
            else if (page == 67)
            {
                page = 72;
            }
            else if (page == 68)
            {
                page = 199;
            }
            else if (page == 69)
            {
                page = 73;
            }
            else if (page == 70)
            {
                page = 74;
            }
            else if (page == 71)
            {
                page = 199;
            }
            else if (page == 72)
            {
                page = 75;
            }
            else if (page == 73)
            {
                page = 76;
            }
            else if (page == 74)
            {
                page = 77;
            }
            else if (page == 75)
            {
                page = 78;
            }
            else if (page == 76)
            {
                page = 79;
            }
            else if (page == 77)
            {
                page = 80;
            }
            else if (page == 78)
            {
                page = 81;
            }
            else if (page == 79)
            {
                page = 82;
            }
            else if (page == 80)
            {
                page = 83;
            }
            else if (page == 81)
            {
                page = 199;
            }
            else if (page == 82)
            {
                page = 199;
            }
            else if (page == 83)
            {
                page = 84;
            }
            else if (page == 84)
            {
                page = 85;
            }
            else if (page == 85)
            {
                page = 86;
            }
            else if (page == 86)
            {
                page = 199;
            }
            else //page 199, reset variables and option 3 button
            {
                page = 2;
                noTracker = 0;
                waterBottle = false;
                option3Button.Text = "";
                option3Button.Enabled = false;
            }

            //display page chosen
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //choose next page
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                noTracker++;
                if (noTracker == 10)
                {
                    page = 13;
                }
                else
                {
                    page = 4;
                }
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 14;
            }
            else if (page == 10)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 21)
            {
                page = 25;
            }
            else if (page == 23)
            {
                page = 32;
            }
            else if (page == 25)
            {
                page = 30;
            }
            else if (page == 26)
            {
                page = 32;
            }
            else if (page == 29)
            {
                //50% chance that it's a student or a creature
                int chance = randGen.Next(1, 3);
                if (chance == 1)
                {
                    page = 38;
                }
                else
                {
                    page = 40;
                }
            }
            else if (page == 36)
            {
                page = 48;
            }
            else if (page == 47)
            {
                page = 62;
            }
            else if (page == 54)
            {
                page = 70;
            }
            else if (page == 57)
            {
                page = 70;
            }
            else if (page == 58)
            {
                page = 70;
            }
            else if (page == 59)
            {
                page = 67;
            }
            else if (page == 199)
            {
                page = 200;
            }

            //display page chosen
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //the option3Button is visible on only one page, so I don't need an if statement with the page number
            //50% chance that it's a student or a creature
            int chance = randGen.Next(1, 3);

            //chose page based on the chance, and whether or not the player took the water bottle
            if (chance == 1)
            {
                if (waterBottle == true)
                {
                    page = 41;
                }
                else
                {
                    page = 42;
                }
            }
            else
            {
                if (waterBottle == true)
                {
                    page = 45;
                }
                else
                {
                    page = 46;
                }
            }

            //display page chosen
            DisplayPage();
        }

        public void DisplayPage()
        {
            //displays the correct screen based on the page number
            switch (page)
            {
                case 1:
                    WritePage("Hello new player!! Are you ready to play the game?");
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 2:
                    WritePage("Welcome back! Are you ready to play again?");
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 3:
                    WritePage("Well then let's get started!");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 4:
                    WritePage("Oh, alright!");
                    Refresh();
                    Thread.Sleep(5000);
                    WritePage("Are you ready now?");
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 5:
                    BackgroundImage = Properties.Resources.empty_classroom;
                    Refresh();
                    WritePage("You wake up and you look around. You're in a classroom. You must have fallen asleep during class.");
                    option1Button.Text = "Continue with your work";
                    option2Button.Text = "Go back to sleep";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 7:
                    WritePage("You look down to check your notes, but realize that they're not on your desk. Look for your binder?");
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 8:
                    WritePage("You go back to sleep, and wake up again to see that the classroom is now empty.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 9:
                    WritePage("You search the compartment under your desk for your binder, but there is only a partially-drank plastic water bottle in it.");
                    option1Button.Text = "Take the water bottle";
                    option2Button.Text = "Leave it";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 10:
                    WritePage("You let your mind wander as your eyes skim the room. What do you look at?");
                    option1Button.Text = "The teacher";
                    option2Button.Text = "The students";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 11:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("You walk home after another uneventful day at school. (Boring Ending 1)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 12:
                    WritePage("Well then let's get started! (Finally)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 13:
                    WritePage("You clearly aren't ready right now. Open this game when you are ACTUALLY READY TO PLAY.");
                    this.Refresh();
                    Thread.Sleep(5000);
                    this.Close();
                    break;
                case 14:
                    WritePage("You leave the water bottle in the desk.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 15:
                    WritePage("You take the water bottle.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 16:
                    WritePage("Your mind begins to wander as your eyes skim the room. What do you look at?");
                    option1Button.Text = "The teacher";
                    option2Button.Text = "The students";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 17:
                    WritePage("You look at the teacher. He's wearing a blue shirt with--wait. Isn't your teacher a woman?");
                    option1Button.Text = "Look at the teacher more closely";
                    option2Button.Text = "Look away";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 18:
                    WritePage("You look around at the students. They have no faces.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 19:
                    WritePage("You observe the teacher. It now occurs to you that you don't recognize him from anywhere. Probably your teacher is sick today.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 20:
                    WritePage("You're too tired for this. You look away from the teacher.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 21:
                    WritePage("The one to your right begins to reach toward you.");
                    option1Button.Text = "Push its hand away";
                    option2Button.Text = "Get out of your chair";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 22:
                    WritePage("You try to figure out what you were working on before you fell asleep, but you start drifting off again.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 23:
                    WritePage("You have nearly fallen asleep again when you hear someone calling your name. You're too tired to be certain, but you assume it is the teacher.");
                    option1Button.Text = "Look at the teacher";
                    option2Button.Text = "Go back to sleep";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 24:
                    WritePage("After you push its hand away with your arm, a weird smell comes from your sleeve as it appears to melt away, and you feel a burning sensation in your arm.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 25:
                    WritePage("You stand up to get away from it. You look around and see the other students are beginning to rise as well, all of them seemingly watching you despite their lack of eyes.");
                    option1Button.Text = "Leave the classroom";
                    option2Button.Text = "Stay to see what they do";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 26:
                    WritePage("As your eyes begin to close, you hear someone calling your name. You're too tired to be certain, but you assume it is the teacher.");
                    option1Button.Text = "Look at the teacher";
                    option2Button.Text = "Go back to sleep";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 27:
                    WritePage("One of the creatures behind you grabs your other arm, and you feel claws sink into your skin.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 28:
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 29:
                    BackgroundImage = Properties.Resources.school_hallway;
                    Refresh();
                    WritePage("You run out of the classroom and head for the front doors. You see a student--could be a creature--standing in the front hallway.");
                    option1Button.Text = "Run back";
                    option2Button.Text = "Go out the window";
                    option3Button.Text = "Confront it";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    option3Button.Enabled = true;
                    option3Button.Visible = true;
                    break;
                case 30:
                    WritePage("All the creatures grab at you, their claws digging into your skin.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 31:
                    WritePage("The teacher looks different. He is suddenly much taller, and seems to somehow cast a shadow across the room, despite there being several lights along the ceiling.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 32:
                    WritePage("You go back to sleep, and wake up again to see that the classroom is now empty.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 33:
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 34:
                    WritePage("As you look closer, you realize that there is a large mouth where his face should be.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 35:
                    BackgroundImage = Properties.Resources.outside_house;
                    Refresh();
                    WritePage("You walk home after another uneventful day at school. (Boring Ending 2)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 36:
                    WritePage("You start to stand up out of shock and the teacher immediately turns toward you. It opens its mouth and you see inside--it is completely devoid of any teeth or tongue, just flesh.");
                    option1Button.Text = "Run out of the classroom";
                    option2Button.Text = "Stay still";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 37:
                    WritePage("You try to run back, but the creature catches up to you.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 38:
                    WritePage("You try to get out the window, and then realize that the window doesn't open and you don't have anything to break it. You hear something running behind you, and then...Nothing.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 39:
                    WritePage("You run back where you came from to try to go down to the other end of the hallway where there is another exit, past the room that you left a minute prior.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 40:
                    WritePage("You try to get out the window, and then realize that the window doesn't open and you don't have anything to break it. You hear something walking behind you. You turn around to see who or what it is, and realize that it's a student. A normal student!");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 41:
                    WritePage("You move slowly toward it, and splash water from the bottle on it. Might as well try it, right?");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 42:
                    WritePage("You run toward it, and then realize you have no plan. It turns around and you see that it's a creature...");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    SoundPlayer runningPlayer = new SoundPlayer(Properties.Resources.running);
                    runningPlayer.Play();
                    break;
                case 43:
                    WritePage("Just as you go by your classroom, the creatures within it ambush you.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 44:
                    WritePage("You don't recognize them, but you don't care, you're just relieved to see another person.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 45:
                    WritePage("You move slowly toward it, and splash water from the bottle on it. Might as well try it, right?");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 46:
                    WritePage("You run toward it, and then realize you have no plan. It turns around and you see that it's a student, who looks very confused and slightly annoyed that you were running at them.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    option3Button.Visible = false;
                    break;
                case 47:
                    WritePage("You're almost out of the classroom when you hear a deafening screech come from behind you. The sound rattles in your skull as a blast of air pushes you onto the ground.");
                    option1Button.Text = "Get up and keep running";
                    option2Button.Text = "Stay still on the ground";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 48:
                    WritePage("The teacher-creature remains still for a few moments, before slowly leaving the classroom.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 49:
                    WritePage("It works! The creature immediately recoils and limps away.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 50:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 51:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 52:
                    WritePage("They appear to be moving along with their schedule as normal. It seems as if they don't know about the creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 53:
                    WritePage("It turns around and...it's a student, who is quite angry at you for splashing water at them for seemingly no reason.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 54:
                    WritePage("You are about to explain why yourself to the student when you hear something approaching form the hallway you came from.");
                    option1Button.Text = "Continue running past the student";
                    option2Button.Text = "Tell the student to run with you";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 55:
                    WritePage("Once the teacher's footsteps can no longer be heard, you carefully get up and look around. The classroom is empty.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 56:
                    BackgroundImage = Properties.Resources.sidewalk;
                    Refresh();
                    WritePage("You continue out of the building through the nearest exit. Outside the school is normal, with no signs of any nightmarish creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 57:
                    WritePage("Suddenly, you hear something approaching from the hallway you came from.");
                    option1Button.Text = "Continue running past the student";
                    option2Button.Text = "Tell the student to run with you";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 58:
                    WritePage("You are about to apologize when you start to hear something approaching from the hallway you came from.");
                    option1Button.Text = "Continue running past the student";
                    option2Button.Text = "Tell the student to run with you";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 59:
                    WritePage("You start to hear a different pair of footsteps coming from the hall. Several pairs, in fact.");
                    option1Button.Text = "Go out into the hallway";
                    option2Button.Text = "Go out the window";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 60:
                    BackgroundImage = Properties.Resources.outside_house;
                    Refresh();
                    WritePage("You walk home, and once you are inside you check your phone. You find that there have been reports of these creatures in schools from your city since 9am that morning, but at first people assumed it was just some random teenagers lying.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 61:
                    WritePage("You get up and try to run but immediately fall back down and hit your head off the doorframe.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 62:
                    WritePage("You stay still, your ears ringing. You feel something grab your arms, too tightly to be human. You're too weak from the noise to stop them.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 63:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 65:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("You find out that the situation is predicted to be under control by the following morning, as firefighters are using hoses to defeat the beings.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 66:
                    BackgroundImage = Properties.Resources.school_hallway;
                    Refresh();
                    WritePage("You go out the hallway and are immediately confronted by a group of what at first seems to be students, but you soon discover that they are very much not students.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 67:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("You open the window and hop out. You feel grateful that your class is on the ground floor of the building.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 68:
                    WritePage("There are many unknowns surrounding these creatures, but you're too tired to think about it much. You go to your bed and take a well-deserved nap. (Good Loner Ending)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 69:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("You run past the student toward the exit. Just as you exit the building, you hear a scream.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 70:
                    BackgroundImage = Properties.Resources.entering_sidewalk;
                    Refresh();
                    WritePage("You grab the student's arm and tell them to run with you. You both make it out of the building.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 71:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("...Needless to say, you don't survive.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 72:
                    BackgroundImage = Properties.Resources.sidewalk;
                    Refresh();
                    WritePage("Outside the school is normal, with no signs of any nightmarish creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 73:
                    BackgroundImage = Properties.Resources.sidewalk;
                    Refresh();
                    WritePage("Outside the school is normal, with no signs of any nightmarish creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 74:
                    BackgroundImage = Properties.Resources.sidewalk;
                    Refresh();
                    WritePage("Outside the school is normal, with no signs of any nightmarish creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 75:
                    BackgroundImage = Properties.Resources.outside_house;
                    Refresh();
                    WritePage("You decide to walk home, and once you are inside you check your phone. You find that there have been reports of these creatures in schools from your city since 9am that morning, but at first people assumed it was just some random teenagers lying.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 76:
                    BackgroundImage = Properties.Resources.outside_house;
                    Refresh();
                    WritePage("You walk home, and once you are inside you check your phone. You find that there have been reports of these creatures in schools from your city since 9am that morning, but at first people assumed it was just some random teenagers lying.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 77:
                     WritePage("You begin to explain what happened in your classroom, and then you see something move past the school windows. You point it out to the student, and as you both look closer you can roughly see the creatures.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 78:
                    WritePage("You find out that the situation is predicted to be under control by the following morning, as firefighters are using hoses to defeat the beings.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 79:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("You find out that the situation is predicted to be under control by the following morning, as firefighters are using hoses to defeat the beings.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 80:
                    WritePage("The student is understandably still skeptical, because the idea of weird creatures being in the school is very odd, and you couldn't see the creatures that well from the window. You go on your phone to try to see if there are any similar instances happening elsewhere, and it turns out there are.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 81:
                    WritePage("There are many unknowns surrounding these creatures, but you're too tired to think about it much. You go to your bed and take a well-deserved nap. (Injured Loner Ending)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 82:
                    WritePage("There are many unknowns surrounding these creatures, but you're too tired to think about it much. You call your parents to let them know you're safe, and then go to your bed and take a nap. (Bad Loner Ending)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 83:
                    WritePage("You find that there have been reports of these creatures in schools from your city since 9am that morning, but at first people assumed it was just some random teenagers lying.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 84:
                    WritePage("You find out that the situation is predicted to be under control by the following morning, as firefighters are using hoses to defeat the beings.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 85:
                    WritePage("The student finds similar articles posted while searching on their own phone, so they believe you, but are still shocked. They thank you for getting them to leave the school. You both decide to walk home.");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 86:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("There are many unknowns surrounding these creatures, but you're too tired to think about it much. You call your parents to let them know you're safe. Once you're home, you go directly to bed and take a well-deserved nap. (Duo Ending)");
                    option1Button.Text = "Next";
                    option1Button.Enabled = true;
                    break;
                case 199:
                    BackgroundImage = null;
                    Refresh();
                    WritePage("Play again?");
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    break;
                case 200:
                    WritePage("Thank you for playing!");
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    this.Refresh();
                    Thread.Sleep(3000);
                    this.Close();
                    break;
            }
        }

        public void WritePage(string message)
        {
            outputLabel.Text = "";
            option1Button.Text = "";
            option2Button.Text = "";
            option1Button.Enabled = false;
            option2Button.Enabled = false;
            outputLabel.Refresh();
            option1Button.Refresh();
            option2Button.Refresh();

            for (int i = 0; i < message.Length; i++)
            {
                outputLabel.Text += $"{message.Substring(i, 1)}";
                outputLabel.Refresh();

                if (message.Substring(i, 1) == "." || message.Substring(i,1) == "!")
                {
                    Thread.Sleep(250);
                }
                else if (message.Substring(i, 1) == ",")
                {
                    Thread.Sleep(100);
                }
                else
                {
                    Thread.Sleep(25);
                }
            }
        }
    }
}