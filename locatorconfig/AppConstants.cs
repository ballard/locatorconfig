﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    class AppConstants
    {
        // config keys

        public const string M_NUM_WAYS = "m_num_ways";
        public const string M_WAY_PREFIX = "m_way_{0}";
        public const string M_SENSOR_PREFIX = "m_sensor_{0}";
        public const string M_CIRCUIT_CONFIG = "m_way_{0}_circuit_config";

        // string constants
        public const string RAIL_CHAIN_STRING = "РЦ {0}";
        public const string STR_WAY = "Путь {0}";
        public const string POINT_A_TEXT = "Точка А: {0}";
        public const string POINT_B_TEXT = "Точка Б: {0}";
        public const string POINT_C_TEXT = "Точка В: {0}";
        public const string POINT_D_TEXT = "Точка Г: {0}";
        public const string MSG_NOT_ENOUGH_USER_RIHTS_TO_WRITE_FILE = "Недостаточно прав у пользователя для работы с программой. Выход из приложения.";
        public const string APPLICATION_FOLDER_NAME = "locatorconfig";
        // int constants
        public const int NUM_OF_SENSORS = 3;
        public const int NUM_OF_POINTS = 4;
        public const int MAX_WAYS = 4;
        public const int MAJOR_VERSION = 2;
        public const int MINOR_VERSION = 1;

    }
}
