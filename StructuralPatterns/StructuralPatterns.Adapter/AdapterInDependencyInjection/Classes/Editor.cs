using System.Collections.Generic;

namespace AdapterInDependencyInjection.Classes
{
    public class Editor
    {
        private readonly IEnumerable<Button> buttons;

        public IEnumerable<Button> Buttons => buttons;

        public Editor(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }

        public void ClickAll()
        {
            foreach (Button button in buttons)
            {
                button.Click();
            }
        }
    }
}
