using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class SpecializedFocusViewModel : MvxViewModel {

        public SpecializedFocusViewModel() {

            Initialize();
        }

        public void Initialize() {

            this.Title = "Specialized Focus";

            this.Content = new List<string> {
                "Adults",
                "College issues",
                "Intersectional & multicultural concerns (prejudice & discrimination)",
                "LGBT,NB concerns",
                "Race and gender issues",
                "Expectant andnew mothers",
                "International culture issues",
                "Family of origin issues",
                "Adult disordered eating",
                "Fitness / body image",
                "Depression and dysthymia",
                "Anxiety and panic",
                "Bipolar disorder",
                "Trauma history and PTSD",
                "Insomnia",
                "Chronic illness"
            };
        }

        public string Title { get; set; }
        public List<string> Content { get; set; }
    }
}