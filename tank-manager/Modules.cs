using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Modules : Entity
    {
        private ModuleType _moduleType;
        private double _prchit;
        private double _prcdeter;

        public virtual ModuleType moduleType
        {
            get;
            set;
        }

        public virtual double prchit
        {
            get;
            set;
        }

        public virtual double prcdeter
        {
            get;
            set;
        }
    }

    enum ModuleType
    {
        Stowage, // Боеукладка
        Engine,  // Двигатель
        Chest, // Бак
        Radio, // Рация
        Turn, // Поворот башни
        Device, // Приборы наблюдения
        Crawler, // Гусеницы
        Body, // Корпус
        Commander, // Командир
        Driver, // Водитель
        Gunner, // Наводчик
        Charging, // Заряжающий
        Operator, // Радист
        Miss // Промах
    }
}
