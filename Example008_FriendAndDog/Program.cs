﻿Console.Clear();
int count = 0;
int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int time = 0;
int friend = 2;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 1;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count++;
}
Console.Write("Собака пробежала " + count + " раз");