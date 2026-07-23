using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3.Util
{
    internal class NullLearnClass
    {
        //警告発生
        string name = null;

        // 警告なし
        string? name2 = null;

        string? name3 = "太郎";

        string? name4 = null;

        string? name5 = "太郎";

        string? name6 = null;

        class User
        {
            public string? Nickname { get; set; }

            public void SayHello()
            {
                Console.WriteLine("こんにちは!");
            }
        }


        class Address
        {
            public string? City { get; set; }
        }

        class User2
        {
            public Address? Address { get; set; }
        }

        public void output()
        {
            string message = name2 ?? "名無しさん";

            Console.WriteLine(message); // "名無しさん"

            string message2 = name3 ?? "名無しさん";

            Console.WriteLine(message2); // "太郎" (null

            int? length = name?.Length;
            Console.WriteLine(length);//null
            int? length2 = name5?.Length;
            Console.WriteLine($"{length2}");//name5のlengthが帰って来る

            // nameがnullなら文字数を数えられないので、その場合は0にする
            int length3 = name6?.Length ?? 0;

            Console.WriteLine(length3); // 0

            string? name7 = "太郎";

            int length4 = name2?.Length ?? 0;

            Console.WriteLine(length2); // 2

            User? user = null;

            user?.SayHello(); // userがnullなので何も起きない(エラーにもならない)

            User? user2 = new User();
            user2?.SayHello();// userの値があるのでメッセージが入る



            string? nickname = null;

            nickname ??= "ゲスト";

            Console.WriteLine(nickname);//nicknameがnullなのでゲスト

            string? nickname2 = "太郎";

            nickname2 ??= "ゲスト"; // nicknameはnullじゃないので太郎がそのままでてくる

            Console.WriteLine(nickname2);
        }


    }
}
