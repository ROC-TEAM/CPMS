using System.ComponentModel.DataAnnotations;

namespace CPMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}