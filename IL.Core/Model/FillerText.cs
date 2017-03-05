using System.Collections.Generic;

namespace IL.Core.Model {
    public static class FillerText {


        private static List<string> _loremList;

        // paragraph
        public const string Paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis augue at felis finibus tempus. Maecenas egestas laoreet ligula, eu molestie nunc tincidunt sed. Mauris euismod, quam ac tempus ultricies, dui ex lobortis mi, in convallis lacus est sed mauris. Aenean congue, nulla eu pulvinar auctor, dui dui malesuada dolor, vel aliquam metus turpis ac risus. Quisque volutpat accumsan erat, at mollis justo pretium eu. Vivamus congue risus vitae suscipit porta. Nulla hendrerit elementum magna ut posuere. Integer sit amet felis at nunc fringilla ultricies vel sit amet urna. Vivamus finibus scelerisque magna, ut pretium nisi bibendum in. Vestibulum ligula enim, accumsan molestie eros sed, lobortis vestibulum dui. Pellentesque dapibus erat sit amet posuere mattis. Sed semper eget lectus molestie scelerisque. In pulvinar orci sapien, at consectetur tellus viverra sodales. Mauris aliquam eu lorem at tincidunt.";

        // words
        public const string Words = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dui.";

        public static List<string> List() {
            if (_loremList == null) {
                CreateList();
            }

            return _loremList;
        }


        private static void CreateList() {

            _loremList = new List<string> {
                "Cras id arcu a dui mollis dignissim.",
                "Curabitur eget metus id ante iaculis malesuada.",
                "Maecenas et velit rhoncus, feugiat augue eget, posuere felis.",
                "Aenean ultrices ligula vitae volutpat convallis.",
                "Curabitur non elit aliquet ante mattis bibendum sed id odio."
            };            
        }

    }
}