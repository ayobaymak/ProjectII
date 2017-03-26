using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Me_Bot.Internal
{
    internal static class Responses
    {
        public const string Feautures =
            "* Answer questions concerning admissions\n\n"
            + "* Link to an admissions officer";

        public const string WelcomeMessage =
              "Hi there\n\n"
            + "I am V-Bot. Designed to anwser questions concerning admissions into Valley View University.  \n"
            + "How can I help you today";

        public const string HelpMessage =
          "I can do the following   \n"
          + Feautures
          + "What would you like me to do?";
    }
}