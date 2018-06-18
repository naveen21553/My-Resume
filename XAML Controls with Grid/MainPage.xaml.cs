using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Text;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAML_Controls_with_Grid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            intro.Click += Intro_Click;
            education.Click += Education_Click;
            responsibility.Click += Responsibility_Click;
            Trainings.Click += Trainings_Click;
            Projects.Click += Projects_Click;
            skills.Click += Skills_Click;
            additionals.Click += Additionals_Click;
            contact.Click += Contact_Click;
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Contact Me";
            mainText1.FontWeight = FontWeights.Normal;
            mainText1.Text = "Naveen Jangid \njangidnaveen39@gmail.com \n+91 99839 08752";

            mainText1_sub1.Text = "";
            mainText2.Text = "";
            mainText2_sub1.Text = "";
            mainText3.Text = "";
            mainText3_sub1.Text = "";
            mainText4.Text = "";
            mainText4_sub1.Text = "";
            mainText5.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";

        }

        private void Additionals_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Additional Information";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "Currently Working on";

            mainText2.FontWeight = FontWeights.Normal;
            mainText2.Text = "Logic and Computational Thinking";

            mainText3.FontWeight = FontWeights.Normal;
            mainText3.Text = "Layout designing in XML and XAML";

            mainText4.FontWeight = FontWeights.Normal;
            mainText4.Text = "Universal Windows Platform App (UWP) development using C# and .NET";

            mainText5.FontWeight = FontWeights.Normal;
            mainText5.Text = "Xamarin from Xamarin University ";

            mainText6.FontWeight = FontWeights.Normal;
            mainText6.Text = "Microsoft Bot framewok and Bot Builder SDK";

            mainText5.FontWeight = FontWeights.SemiBold;
            mainText5.Text = "Hobby - Photoshop";

            mainText1_sub1.Text = "";
            mainText2_sub1.Text = "";
            mainText3_sub1.Text = "";
            mainText4_sub1.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";

        }

        private void Skills_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Skills";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "Languages Known - ";
            mainText1_sub1.FontWeight = FontWeights.Normal;
            mainText1_sub1.Text = "\nC# : Beginner to Intermideate \t\t\t\tJava : Beginner to Intermideate \n\nC, C++ : Intermideate to Advanced \t\t\tPython : Beginner to Intermideate";

            mainText2.FontWeight = FontWeights.SemiBold;
            mainText2_sub1.FontWeight = FontWeights.Normal;
            mainText2.Text = "Platforms Known - ";
            mainText2_sub1.Text = "\nCloud Platforms - Microsoft Azure, Google Cloud Platform \n\nOperating Systems: Linux Windows";

            mainText3.FontWeight = FontWeights.SemiBold;
            mainText3.Text = "Technologies Known - ";
            mainText3_sub1.FontWeight = FontWeights.Normal;
            mainText3_sub1.Text = "Cloud Computing - Azure VM Service, Azure Web App Sevices, Google Cloud Platform VM service \nMachine Learning & Data Visualisation - Python Libraries (SciKit Learn, Numpy, MatPlotLib, TemsorFlow, Pandas)";

            mainText4.FontWeight = FontWeights.SemiBold;
            mainText4.Text = "Latest Addition - "; 
            mainText4_sub1.FontWeight = FontWeights.Normal;
            mainText4_sub1.Text = "Universal Windows Platform App Development - C# & .NET ";

            mainText5.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";

        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Projects - Completed and ongoing";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "UWP - my Resume";
            mainText1_sub1.FontWeight = FontWeights.Light;
            mainText1_sub1.Text = "Date of Completion: Jun 11, 2018";

            mainText2.FontWeight = FontWeights.SemiBold;
            mainText2_sub1.FontWeight = FontWeights.Light;
            mainText2.Text = "UWP - XAML Basics";
            mainText2_sub1.Text = "Date of Completion: Jun 9, 2018\nGitHub: https://github.com/naveen21553/workingWithXAML";

            mainText3.FontWeight = FontWeights.SemiBold;
            mainText3.Text = "Chatbot - using Bot Builder Framework";
            mainText3_sub1.FontWeight = FontWeights.Light;
            mainText3_sub1.Text = "ongoing\nGitHub: https://github.com/naveen21553/myFirstBot";

            mainText4.FontWeight = FontWeights.SemiBold;
            mainText4.Text = "Stock Market Prediction - Azure Machine Learning Studio";
            mainText4_sub1.FontWeight = FontWeights.Light;
            mainText4_sub1.Text = "Android app: https://goo.gl/9dqcws \nAzure Gallery: https://gallery.azure.ai/Experiment/Stock-Prediction";

            mainText5.FontWeight = FontWeights.SemiBold;
            mainText5.Text = "ChatBot - Using Dialogflow api";
            mainText5_sub1.FontWeight = FontWeights.Light;
            mainText5_sub1.Text = "Link: https://bot.dialogflow.com/bot_naveen";

            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";

        }

        private void Trainings_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Trainings Courses and Certifications";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "Fundamentals of C#";
            mainText1_sub1.FontWeight = FontWeights.Light;
            mainText1_sub1.Text = "Microsoft Virual Academy \nDate of Completion: Jun 6, 2018";

            mainText2.FontWeight = FontWeights.SemiBold;
            mainText2_sub1.FontWeight = FontWeights.Light;
            mainText2.Text = "JAVA Core: Fundamentals";
            mainText2_sub1.Text = "Online Sources\nDate of Completion: Jun 7, 2018";

            mainText3.FontWeight = FontWeights.SemiBold;
            mainText3.Text = "Creating Chatbots";
            mainText3_sub1.FontWeight = FontWeights.Light;
            mainText3_sub1.Text = "Microsoft Virtual Academy - ongoing";

            mainText4.FontWeight = FontWeights.SemiBold;
            mainText4.Text = "Universal Windows Platform App Development";
            mainText4_sub1.FontWeight = FontWeights.Light;
            mainText4_sub1.Text = "Microsoft Virtual Academy - ongoing";

            mainText5.FontWeight = FontWeights.SemiBold;
            mainText5.Text = "Xamarin - Android Development";
            mainText5_sub1.FontWeight = FontWeights.Light;
            mainText5_sub1.Text = "Xamarin University - ongoing";

            mainText6.FontWeight = FontWeights.SemiBold;
            mainText6.Text = "Entry Level Software Development";
            mainText6_sub1.FontWeight = FontWeights.Light;
            mainText6_sub1.Text = "Microsoft / EdX - ongoing";

            mainText7.FontWeight = FontWeights.SemiBold;
            mainText7_sub1.FontWeight = FontWeights.Light;
            mainText7.Text = "RedHat System Administration";
            mainText7_sub1.Text = "Network Nuts \nDate of Completion: Mar 2018";
        }

        private void Responsibility_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Positions of Responsibility";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "Microsoft Student Partner";
            mainText1_sub1.Text = "Under this we learn the cutting edge " +
                "technologies from leading technologies and spread this knowledge " +
                "among fellow students.";
            mainText1_sub1.FontWeight = FontWeights.Light;

            mainText2.FontWeight = FontWeights.SemiBold;
            mainText2.Text = "JECRC Student Ambassador";
            mainText2_sub1.FontWeight = FontWeights.Light;
            mainText2_sub1.Text = "A dedicated group of our college in which we encourage people to " +
            "enhance their skills and participate in the partner programs of different " +
            "companies.";

            mainText3.Text = "";
            mainText3_sub1.Text = "";
            mainText4.Text = "";
            mainText4_sub1.Text = "";
            mainText5.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";
        }

        private void Education_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Education";
            mainText1.Text = "Bachelor of Technolofy (BTech) - Computer Science";
            mainText1_sub1.FontWeight = FontWeights.Light;
            mainText1_sub1.Text = "(2016-2020)\nJECRC College";

            mainText2.FontWeight = FontWeights.SemiBold;
            mainText2.Text = "XII (Senior Secondary) Science (Math)";
            mainText2_sub1.FontWeight = FontWeights.Light;
            mainText2_sub1.Text = "Year of Completion: 2016\nCBSE - Prince Academy\nScore: 80.80%";

            mainText3.FontWeight = FontWeights.SemiBold;
            mainText3.Text = "X (Secondary)";
            mainText3_sub1.FontWeight = FontWeights.Light;
            mainText3_sub1.Text = "Year of Completion: 2014\nCBSE - Prince Academy\nScore: CGPA 9.8";

            mainText4.Text = "";
            mainText4_sub1.Text = "";
            mainText5.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";
        }

        private void Intro_Click(object sender, RoutedEventArgs e)
        {
            title.Text = "Basic Information";
            mainText1.FontWeight = FontWeights.SemiBold;
            mainText1.Text = "Hello! This is [Naveen Jangid]" +
                "(https://instagram.com/naveen_215), a student of Computer Science and Engineering from Jaipur Rajasthan";
            mainText1.Margin = new Thickness(20, 20, 325, 0);
            
            mainText2.Margin = new Thickness(20, 20, 325, 0);
            mainText2.Text = "I am an aspirant of cutting edge technologies. I see a lot of potential in modern Computer Science Technologies," +
                " and the most trendy example of which is the Machine Learning and AI.There are many growing fields in Computer Science that " +
                "can change the world. " +
                "I, as an aspirant of these technologies, wish to play my role in a significant way.With the scholarship, I wish to pursue " +
                "applied computer science learning giving in the best I can. Currently, I'm learning to build intelligent Machine Learning " +
                "models for language translation and market prediction and also began to get into android app development.";

            mainText3.Text = "The greatest adversity I faced so far was either lack of knowledge or no access to cloud computing for training my models, "+
                "and it is just insane to train a machine learning model with a dataset spanning to several Gigs onto a local machine. " +
                "I figured out I needed to learn and improve my understanding over optimization of the training processes and needed " +
                "access to cloud computing power of the tech giants.";

            mainText4.Text = "I started learning with tensorflow tutorials on the internet and for cloud access, I got an opportunity to be a part of " +
                "Microsoft's Student Partner Program (MSP Program), in which access to their cloud and other services becomes easy and free for me. " +
                "Yet I was wondering to explore, and I got student benefits on Google cloud platform and I'm already loving it.";

            mainText1_sub1.Text = "";
            mainText2_sub1.Text = "";
            mainText3_sub1.Text = "";
            mainText4_sub1.Text = "";
            mainText5.Text = "";
            mainText5_sub1.Text = "";
            mainText6.Text = "";
            mainText6_sub1.Text = "";
            mainText7.Text = "";
            mainText7_sub1.Text = "";
        }
    }
}
