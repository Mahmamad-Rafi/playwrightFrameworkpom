using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pagemodel.pages
{
    public class contactus
    {

        IPage page;

        public contactus(IPage page)
        {
            this.page = page;
        }

        public async Task ClickContactUs()
        {
            await page.ClickAsync("a[href='/contact_us']");
        }
        public async Task VerifyGetInTouchVisible()
        {
            await Assertions. Expect(page.Locator("//h2[text()='Get In Touch']")).ToBeVisibleAsync();
        }

        public async Task FillContactForm(string name, string email, string subject, string message)
        {
            await page.FillAsync("input[name='name']", name);
            await page.FillAsync("input[name='email']", email);
            await page.FillAsync("input[name='subject']", subject);
            await page.FillAsync("textarea[name='message']", message);
        }

        public async Task UploadFile(string filePath)
        {
            await page.SetInputFilesAsync("input[name='upload_file']", filePath);
        }

        public async Task HandleDialog()
        {
             page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Dialog message: {dialog.Message}");
                await dialog.AcceptAsync();
            };
        }

        public async Task SubmitForm()
        {
            await page.ClickAsync("input[type='submit']");
        }

        public async Task VerifySuccessMessage()
        {
            await Assertions. Expect(page.Locator("div.status.alert.alert-success"))
                .ToHaveTextAsync("Success! Your details have been submitted successfully.");
        }

        public async Task ClickHomeAndVerify()
        {
            await page.ClickAsync("text=Home");
            await Assertions.Expect(page.GetByText("Home")).ToBeVisibleAsync();
        }
        }
    }
