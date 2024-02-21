namespace Module12Algos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаём несколько пользователей для демонстрации работы программы
            User user1 = new User(login: "Ivan555", name: "Иван", isPremium: true);
            User user2 = new User(login: "Petr666", name: "Пётр", isPremium: false);
            User user3 = new User(login: "Sergei777", name: "Сергей", isPremium: false);
            User user4 = new User(login: "Valentin69", name: "Валентин", isPremium: true);

            // добавляем их в список, как указано в задании
            List<User> userList = [user1, user2, user3, user4];

            // у каждого юзера в списке вызываем приветствие, если нет премиумподписки, вызываем статический метод с показом рекламы
            foreach (var user in userList)
            {
                user.Greetings();
                if (!user.IsPremium)
                {
                    User.ShowAds();
                }
            }
        }
    }
}
