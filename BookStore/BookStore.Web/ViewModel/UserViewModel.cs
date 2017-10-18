using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "Informe um usuario válido")]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe uma senha válida")]
        [StringLength(6, ErrorMessage = "Deve conter entre 6 - 15 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]       
        public string Password { get; set; }

        [Display(Name = "Confirmar senha")]
        [Required(ErrorMessage = "Confirme sua senha")]
        [StringLength(6, ErrorMessage = "Deve conter entre 6 - 15 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Informe seue email")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }  
        
    }
}