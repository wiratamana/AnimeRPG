using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tamana
{
    public class IngameDate : SingletonMonobehaviour<IngameDate>
    {
        [SerializeField] private TextMeshProUGUI DateTime;

        private static System.DateTime dateTime;

        private const string KEY = "INGAME_DATE";

        public static int Year { get { return dateTime.Year; } }
        public static int Month { get { return dateTime.Month; } }
        public static int Day { get { return dateTime.Day; } }

        private void Start()
        {
            if (!PlayerPrefs.HasKey(KEY))
                dateTime = new System.DateTime(1, 1, 1);

            else
            {
                GameDate gameDate = JsonUtility.FromJson<GameDate>(PlayerPrefs.GetString(KEY));

                dateTime = new System.DateTime(gameDate.year, gameDate.month, gameDate.day);
            }

            instance.DateTime.text = dateTime.ToString("(ddd) yyyy/MM/dd");
        }

        public static void AdvanceToNextDay()
        {
            dateTime = dateTime.AddDays(1);

            instance.DateTime.text = string.Format($"({dateTime.DayOfWeek.ToString("ddd")} {dateTime.Year}/{dateTime.Month}/{dateTime.Day})");
        }
    }

}
