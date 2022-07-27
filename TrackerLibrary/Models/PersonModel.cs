
namespace ManagerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Уникальный идентификатор для приза.
        /// </summary>
        public int Id { get; set; }

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

        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }
    }
}
