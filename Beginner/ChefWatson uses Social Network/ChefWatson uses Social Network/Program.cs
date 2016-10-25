using System;
using System.Linq;

namespace ChefWatson_uses_Social_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int numOfSpecial = input[0];
            int numOfPost = input[1];
            int[] specialFriendIndex = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int[] friendIndex = new int[numOfPost-numOfSpecial];
            int[] specialFriendPopularity = new int[numOfSpecial];
            int[] friendPopularity = new int[numOfPost-numOfSpecial];
            string[] specialFriendString = new string[numOfSpecial];
            string[] friendString = new string[numOfPost-numOfSpecial];
            int numOfSpecialFriend = 0, numOfNotSpecialFriend = 0;
            for(int i = 0; i < numOfPost; i++)
            {
                string[] post = Console.ReadLine().Trim().Split(' ');
                if (specialFriendIndex.Contains(Convert.ToInt32(post[0])))
                {
                    specialFriendPopularity[numOfSpecialFriend] = Convert.ToInt32(post[1]);
                    specialFriendString[numOfSpecialFriend] = post[2];
                    numOfSpecialFriend++;
                }
                else
                {
                    friendIndex[numOfNotSpecialFriend] = Convert.ToInt32(post[0]);
                    friendPopularity[numOfNotSpecialFriend] = Convert.ToInt32(post[1]);
                    friendString[numOfNotSpecialFriend] = post[2];
                    numOfNotSpecialFriend++;
                }
            }
            Array.Sort(specialFriendPopularity, specialFriendString);
            Array.Sort(friendPopularity, friendString);
            foreach(string item in specialFriendString.Reverse())
            {
                Console.WriteLine(item);
            }
            foreach(string item in friendString.Reverse())
            {
                Console.WriteLine(item);
            }
        }
    }
}
