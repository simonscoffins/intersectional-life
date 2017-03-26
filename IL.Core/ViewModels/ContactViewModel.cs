using IL.Core.Model;
using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {
    public class ContactViewModel : MvxViewModel {



        public ContactViewModel() {
            Initialize();
        }

        public void Initialize() {

            this.Title = "Contact";

            this.Logo = Constants.Logo;
            this.Name = Constants.FullName;

            this.Address1 = Constants.Address1 + ", ";
            this.Address2 = Constants.Address2;

            this.City = Constants.City + ", ";
            this.State = Constants.State + " ";
            this.ZipCode = Constants.ZipCode;

            this.Phone = Constants.Phone;
            this.Email = Constants.Email;
        }

        public string Title { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }



        //public MvxCommand BlahCommand {

        //    get {
        //        return new MvxCommand(() => {
        //            var x = 100;
        //            var y = x;
        //        });
        //    }
        //}

    }
}