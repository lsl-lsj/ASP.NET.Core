using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _08SHA1Service
{
    public class TestModel : PageModel
    {
        private readonly SHA1Computer _hash;
        public TestModel(SHA1Computer hash)
        {
            _hash = hash;
        }

        public PageResult OnGet()
        {
            return Page();
        }

        public string HashedText { get; private set; }

        [BindProperty]
        public string InputText { get; set; }

        public PageResult OnPostUpload()
        {
            if (string.IsNullOrEmpty(InputText))
            {
                return Page();
            }
            HashedText = _hash.Compute(InputText);
            return Page();
        }
    }
}