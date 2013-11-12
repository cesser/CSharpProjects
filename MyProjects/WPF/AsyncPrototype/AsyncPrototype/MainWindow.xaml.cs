using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Task<int> intTask = ExampleMethodAsync();
                // You can do other work here that doesn't require the result from
                // ExampleMethodAsync. . . .
                ResultsTextBox.Text += "Doing other work before awaiting intTask. . . . .\n";

                // Now wait for intTask to complete so that you can access the int result.
                int intResult = await ExampleMethodAsync2();

                // You can combine the previous steps:
                //int intResult = await ExampleMethodAsync();

                // Process the result (intResult) . . . .
                ResultsTextBox.Text += String.Format("Length: {0}\n\n", intResult);
            }
            catch (Exception)
            {
                // Process the exception if one occurs.
            }
        }

        public Task<int> ExampleMethodAsync2()
        {


            return Task.Run<int>(async () => { await Task.Delay(10000); return 10; });
        }

        public void Calculate()
        {
            for (int i = 0; i < 1000; i++)
            {
                
            }
        }

        public async Task<int> ExampleMethodAsync()
        {
            var httpClient = new HttpClient();

            // The following line activates GetStringAsync, an asynchronous method that
            // eventually returns a string.
            Task<string> contentsTask = httpClient.GetStringAsync("http://msdn.microsoft.com");

            // While the task is active, but before you await it, you can do other work.
            ResultsTextBox.Text += "Doing other work before awaiting contentsTask. . . . .\n";

            
            // When you await contentsTask, execution in ExampleMethodAsync is suspended
            // until contentsTask is complete. In the meantime, control returns to the 
            // caller, StartButton_Click.
            string contents = await contentsTask;

            // After contentTask completes, you can calculate the length of the string.
            int exampleInt = contents.Length;

            //// You can combine the previous sequence into a single statement.
            //int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;

            ResultsTextBox.Text += "Preparing to finish ExampleMethodAsync.\n";

            // After the following return statement, any method that's awaiting
            // ExampleMethodAsync (in this case, StartButton_Click) can get the 
            // integer result.
            return exampleInt;
        }
    }
}
