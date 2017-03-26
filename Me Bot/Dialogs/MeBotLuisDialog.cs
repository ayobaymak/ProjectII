using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Luis.Models;
using System.Threading;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;
using System.Text;
using System.Configuration;
using Me_Bot.Internal;

namespace Me_Bot.Dialogs
{
    [LuisModel("3a75082f-a8ad-433b-9fc2-5992a5c6c90f", "61017849392e4a62831e8a2794da3fad")]
    [Serializable]
    public class MeBotLuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        [LuisIntent("")]
        public async Task None(IDialogContext context, IAwaitable<IMessageActivity> message,  LuisResult result)
        {
            var cts = new CancellationTokenSource();
            await context.Forward(new GreetingsDialog(), GreetingDialogDone, await message, cts.Token);
        }

       


        #region Private
        private async Task GreetingDialogDone(IDialogContext context, IAwaitable<bool> result)
        {
            var success = await result;
            if (!success)
                await context.PostAsync("I'm sorry. I didn't understand you, could you be more specific?");

            context.Wait(MessageReceived);
        }

        #endregion

        [LuisIntent("AboutMe")]
        public async Task AboutMe(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Valley View University is a Seventh-day Adventist Instituition of higher learning.");
            await context.PostAsync(@"We offer wholistic education.");

            context.Wait(MessageReceived);
        }

        [LuisIntent("Location")]
        public async Task Location(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Valley View University is located at");

            context.Wait(MessageReceived);
        }

        [LuisIntent("Accomodation")]
        public async Task Accomodation(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Yes, the University has accommodation for students’ utilization. 
                More of them are being built to accommodate the increasing number of the student population.");
            await context.PostAsync(@"Currently two Male and female hostels are available  \n\n
                M.A Bediako Hall And J.J Nortey Hall for Males \n
                E.G White Hall And NAGSDA Hall for females.");

            context.Wait(MessageReceived);
        }

        [LuisIntent("Affiliations")]
        public async Task Affiliations(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Valley View University has affiliation with Andrews
            University and Grigs University (USA)");

            context.Wait(MessageReceived);
        }

        [LuisIntent("CareerAdvice")]
        public async Task CareerAdvice(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Yes, the there are experienced counselors that can assist students and 
            prospective students with all their academic needs.");

            context.Wait(MessageReceived);
        }

        [LuisIntent("Counselling")]
        public async Task Counselling(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Yes, the University has a Counseling Centre, 
            manned by an experienced counselor and a chaplain.");

            context.Wait(MessageReceived);
        }

        [LuisIntent("CostOfLiving")]
        public async Task CostOfLiving(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"For information on undergraduate or postgraduate 
            fees and expenses, please call our Finance office (+233-307-011877) and 
            they will be happy to answer all your queries.");

            context.Wait(MessageReceived);
        }

        [LuisIntent("CoursesOffered")]
        public async Task CoursesOffered(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"The University currently offers undergraduate programs, 
            postgraduate programs, as well as other short certificate courses, 
            click here https://vvu.edu.gh/index.php/typography/academic-program to see list of available courses and programs ");

            context.Wait(MessageReceived);
        }

        [LuisIntent("DressCode")]
        public async Task DressCode(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"We do not have any prescribed uniform or attire. 
            We, however, as a christian tertiary institution, insist that our students dress decently.");

            context.Wait(MessageReceived);
        }

    }
}