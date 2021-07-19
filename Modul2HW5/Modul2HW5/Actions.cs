using System;

namespace Modul2HW5
{
    public class Actions
    {
        private readonly ILogger _logger;

        public Actions(ILogger log)
        {
            _logger = log;
        }

        public bool FirstMethod()
        {
            _logger.WriteInfo($"Старт {nameof(FirstMethod)}:");
            return true;
        }

        public void SecondMethod()
        {
            throw new BusinessException($"Неправильная логика {nameof(SecondMethod)}:");
        }

        public void ThirdMethod()
        {
            throw new Exception($"Сломал логику {nameof(ThirdMethod)}");
        }
    }
}
