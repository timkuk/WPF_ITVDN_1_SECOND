﻿using System;
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
//Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.
namespace Lesson13HomeWork13_Task3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
