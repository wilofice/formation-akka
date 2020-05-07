using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class CustomRichTextExemple
    {
        private async static void Start()
        {
            CustomText resultsTextBox = new CustomText();

            // The display lines in the example lead you through the control shifts.
            resultsTextBox.Text = "ONE:   Entering Calling method Start.\r\n" +
                "           Calling AccessTheWebAsync.\r\n";

            Console.WriteLine(resultsTextBox.Text);

            Task<int> getLengthTask = AccessTheWebAsync(resultsTextBox);


            resultsTextBox.Text = "\r\nFOUR:  Back in Calling method Start.\r\n" +
                "           Task getLengthTask is started.\r\n" +
                "           About to await getLengthTask -- no caller to return to.\r\n";

            Console.WriteLine(resultsTextBox.Text);

            int contentLength = await getLengthTask;


            resultsTextBox.Text = "after await getLengthTask + last message from " + resultsTextBox.Text;
            Console.WriteLine(resultsTextBox.Text);


            resultsTextBox.Text = "\r\nSIX:   Back in Calling method Start.\r\n" +
                "           Task getLengthTask is finished.\r\n" +
                "           Result from AccessTheWebAsync is stored in contentLength.\r\n" +
                "           About to display contentLength and exit.\r\n";

            Console.WriteLine(resultsTextBox.Text);


            resultsTextBox.Text = "last message from AccessTheWebAsync" + resultsTextBox.Text +
                $"\r\nLength of the downloaded string: {contentLength}.\r\n";

            Console.WriteLine(resultsTextBox.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        async static Task<int> AccessTheWebAsync(CustomText resultsTextBox)
        {
            resultsTextBox.Text = "\r\nTWO:   Entering AccessTheWebAsync.";
            Console.WriteLine(resultsTextBox.Text);


            // Declare an HttpClient object.
            HttpClient client = new HttpClient();

            resultsTextBox.Text = "\r\n           Calling HttpClient.GetStringAsync.\r\n";

            Console.WriteLine(resultsTextBox.Text);


            // GetStringAsync returns a Task<string>.
            Task<string> getStringTask = client.GetStringAsync("https://msdn.microsoft.com");

            Console.WriteLine(resultsTextBox.Text);


            resultsTextBox.Text = "\r\nTHREE: in AccessTheWebAsync.\r\n" +
                "           Task getStringTask is started.";

            Console.WriteLine(resultsTextBox.Text);


            // AccessTheWebAsync can continue to work until getStringTask is awaited.

            resultsTextBox.Text =
                "\r\n           About to await getStringTask and return a Task<int> to Calling method Start.\r\n";

            Console.WriteLine(resultsTextBox.Text);


            // Retrieve the website contents when task is complete.
            string urlContents = await getStringTask;

            Console.WriteLine(resultsTextBox.Text);


            resultsTextBox.Text = "\r\nFIVE:  Back in AccessTheWebAsync." +
                "\r\n           Task getStringTask is complete." +
                "\r\n           Processing the return statement." +
                "\r\n           Exiting from AccessTheWebAsync.\r\n";


            Console.WriteLine(resultsTextBox.Text);

            int length = urlContents.Length;

            Console.WriteLine("just after int length = urlContents.Length; it didn't wait " + resultsTextBox.Text);



            return length;

        }
    }

    class CustomText
    {
        public string Text { get; set; }
    }
}



