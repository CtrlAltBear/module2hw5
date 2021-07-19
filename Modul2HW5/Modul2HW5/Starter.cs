﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    public class Starter
    {
        private readonly Actions _actions;
        private readonly ILogger _logger;
        private readonly Random _rnd;
        public Starter(Actions actions, ILogger log)
        {
            _actions = actions;
            _logger = log;
            _rnd = new Random();
        }

        public void Run()
        {
            for (var i = 0; i < 100; i++)
            {
                try
                {
                    CallRandomMethod();
                }
                catch (BusinessException ex)
                {
                    _logger.WriteWarning($"Действие получило исключение: {ex.Message}");
                }
                catch (Exception ex)
                {
                    _logger.WriteError($"Действие не выполнено: {ex}");
                }
            }
        }

        private void CallRandomMethod()
        {
            var num = _rnd.Next(3);

            switch (num)
            {
                case 0:
                    _actions.FirstMethod();
                    break;
                case 1:
                    _actions.SecondMethod();
                    break;
                case 2:
                    _actions.ThirdMethod();
                    break;
            }
        }
    }
}
