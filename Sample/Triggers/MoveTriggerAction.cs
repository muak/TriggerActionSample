using System;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace Sample.Triggers
{
    public class MoveTriggerAction:TriggerAction<VisualElement>
    {
        public bool IsActive { get; set; }

        public MoveTriggerAction()
        {
        }

        protected override void Invoke(VisualElement sender)
        {
            if (IsActive)
            {
                sender.TranslationX = -sender.Width;
                sender.Opacity = 0;


                sender.TranslateTo(0, 0);
                sender.FadeTo(1);
            }
            else
            {
                sender.TranslateTo(sender.Width, 0);
                sender.FadeTo(0);
            }
        }
    }
}
