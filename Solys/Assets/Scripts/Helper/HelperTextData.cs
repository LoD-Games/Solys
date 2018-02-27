﻿using System.Collections.Generic;

public static class HelperTextData{

    public static string[] GetRussian(int index)
    {
        

        switch(index)
        {
            case 3:
                return new string[] {
                    "Добро пожаловать в Solus! Нажмите на эту подсказку для продолжения.",
                    "Нарисуйте линию, что бы диск попал в портал.",
                    "После этого запустите симуляцию нажав на кнопку в левом нижнем углу.",
                    "Вы можете использовать ластик что бы исправить небольшие недочёты",
                    "Нажмите на ластик трижды что бы удалить все линии"
                };
            case 5:
                return new string[]{
                    "Для рисования линий тратится шкала энергии.",
                    "Ваш результат зависит от количества потраченной энергии.",
                    "Чем больше энергии останется - тем лучше!"
                };
            case 6:
                return new string[] {
                    "Коснитесь тёмного блока во время симуляции!"
                };
            case 7:
                return new string[] {
                    "Каждый запуск симуляции тратит одно очко энергии.",
                    "Но её не сложно пополнить.",
                    "Не бойтесь эксперементировать!"
                };
            case 8:
                return new string[] {
                    "Испоьзуйте два пальца что бы перемещать камеру."
                };
            case 10:
                return new string[] {
                    "Познакомьтесь с блоком Гравитации!",
                    "Когда диск пролетает мимо этого блока - направление гравитации меняется."
                };
            case 14:
                return new string[] {
                    "А это блок Силы.",
                    "Он толкает диск в по направлению стрелки."
                };
            case 16:
                return new string[] {
                    "А это блок Ускорения.",
                    "Пролетая мимо этого блока диск ускоряется"
                };
            case 20:
                return new string[] {
                    "Блок Телепорта.",
                    "Диск перемещается от входа телепорта к выходу."
                };

            default:
                return new string[0];
        }
            
        
        
    }

}
