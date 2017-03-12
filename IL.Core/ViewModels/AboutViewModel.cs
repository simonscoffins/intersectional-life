using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class AboutViewModel : MvxViewModel {


        public AboutViewModel() {
            Initialize();
        }


        public void Initialize() {
            this.Title = "About";
            this.Heading = "ELISABETH “DR.LIZ” YAELINGH - SCOFFINS, PH.D.";

            this.Paragraph1 = "Have you been feeling nervous? Waking at night with nightmares, or having racing thoughts and unable to get back to sleep? Do you feel unmotivated to do things you need to do and even things you like to do? Have you lost your joy in everyday life? Are you tired all the time even though your physician says you're healthy? Feeling unreasonable guilt? Are you isolated? I would like to help you gently unpack the circumstances that led to your feeling unhappy so that you can begin to heal yourself.";

            this.Paragraph2 = "I have worked with people from diverse walks of life for 15 years. I recognize we do not all have the same environments and resources. I see you as the expert on your life, and I will offer respectful support in managing stresses and overcoming difficulties, whether they are within yourself or in your environment.";

            this.Paragraph3 = "In the heart of downtown Lancaster right next to the public library and around the corner from the municipal city bus station.";

            this.Paragraph4 = "Dr. Yaelingh-Scoffins is a fully licensed Clinical Psychologist who trained at Eastern Michigan University. She has worked in local group and individual private practice as well as a number of college and university counseling centers. Her research and teaching focus is Prejudice and Discrimination / Multicultural Psychology.";

            this.Qualifications = "PS017478 Pennsylvania";
        }


        public string Title { get; set; }
        public string Heading { get; set; }

        public string Paragraph1 { get; set; }
        public string Paragraph2 { get; set; }
        public string Paragraph3 { get; set; }
        public string Paragraph4 { get; set; }
        
        public string Qualifications { get; set; }

    }
}