using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkLibrary
{
    /// <summary>
    /// Хранит информацию о пользователе
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Содержит логин
        /// </summary>
        public string Login {get; set;}

        /// <summary>
        /// Содержит пароль
        /// </summary>
        public string Password { get; set;}

        /// <summary>
        /// Содержит роль пользователя
        /// </summary>
        public Role Role { get; set;}
    }
}
