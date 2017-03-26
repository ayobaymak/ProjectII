using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestMatchDialog;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;

namespace Me_Bot.Dialogs
{
    [Serializable]
    public class GreetingsDialog : BestMatchDialog<bool>
    {
        [BestMatch (new string[] {"Hi", "Hi There", "Hello there", "Hey", "Hello", "Hey there",
        "Greetings", "Good morning", "Good afternoon", "Good evening", "Good day"}, 
            threshold: 0.5, ignoreCase: true, ignoreNonAlphaNumericCharacters: true)]

        public async Task WelcomeGreeting(IDialogContext context, string messageText)
        {
            await context.PostAsync("Hello there, how can i help you");
            context.Done(true);
        }

        [BestMatch (new string[] { "bye", "bye bye", "got to go", "see you later",
            "later", "adios", "see ya"})]
        public async Task FarewellGreeting(IDialogContext context, string messageText)
        {
            await context.PostAsync("Bye.");
            context.Done(true);
        }

        public override async Task NoMatchHandler(IDialogContext context, string messageText)
        {
            context.Done(false);
        }
    }
}