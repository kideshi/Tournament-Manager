
namespace ManagerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Действующая электронная почта человека.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Действующий номер телефона человека.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
