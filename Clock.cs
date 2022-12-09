using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Text[] UI_TIME_TEXT;
    public Text[] UI_DATE_TEXT;
    public TimeFormat timeFormat = TimeFormat.Hour_12;
    public DateFormat dateFormat = DateFormat.MM_DD_YYYY;
    public float secPerMin = 6;

    private string _time;
    private string _date;

    private bool isAm = false;
    //private bool isPm = false;

    public int hr;
    public int min;

    public int day;
    int month;
    int year;

    public int maxHr = 24;
    int maxMin = 60;

    int maxDay = 30;
    int maxMonth = 12;

    float timer = 0;

    public enum TimeFormat
    {
        Hour_24,
        Hour_12
    }
    public enum DateFormat
    {

        MM_DD_YYYY,
        DD_MM_YYYY,
        YYYY_MM_DD,
        YYYY_DD_MM
    }

    private void Awake()
    {
        hr = 12;
        min = 00;
        day = 7;
        month = 11;
        year = 2021;




    }


    // Update is called once per frame
    public void Update()
    {
        if (hr < 12)
        {
            isAm = true;


        }
        else
        {
            isAm = false;

        }

        if (timer >= secPerMin)
        {
            min++;
            if (min >= maxMin)
            {
                min = 0;
                hr++;
                if (hr == maxHr)
                {
                    hr = 0;
                    day++;
                    if (day >= maxDay)
                    {
                        day = 1;
                        month++;
                        if (month >= maxMonth)
                        {
                            month = 1;
                            year++;
                        }
                    }
                }
            }

            SetTimeDateString();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void SetTimeDateString()
    {
        switch (timeFormat)
        {
            case TimeFormat.Hour_12:
                {
                    int h;

                    if (hr >= 13)
                    {
                        h = hr - 12;
                        isAm = false;
                        
                    }
                    else if (hr == 0)
                    {
                        h = 12;
                    }
                    else
                    {
                        h = hr;
                    }

                    _time = h + ":";

                    if (min <= 9)
                    {
                        _time += "0" + min;
                    }
                    else
                    {
                        _time += min;
                    }

                    if (isAm == true)
                    {
                        _time += " AM";
                    }
                    else
                    {
                        _time += " PM";
                    }
                    break;
                }
            case TimeFormat.Hour_24:
                {
                    if (hr <= 9)
                    {
                        _time = "0" + hr + ":";
                    }
                    else
                    {
                        _time = hr + ":";
                    }

                    if (min <= 9)
                    {
                        _time += "0" + min;
                    }
                    else
                    {
                        _time += min;
                    }
                    break;
                }
        }
        switch (dateFormat)
        {
            case DateFormat.DD_MM_YYYY:
                {
                    _date = day + "/" + month + "/" + year;
                    break;
                }
            case DateFormat.MM_DD_YYYY:
                {
                    _date = month + "/" + day + "/" + year;
                    break;
                }
            case DateFormat.YYYY_DD_MM:
                {
                    _date = year + "/" + day + "/" + month;
                    break;
                }
            case DateFormat.YYYY_MM_DD:
                {
                    _date = year + "/" + month + "/" + day;
                    break;
                }
        }

        for (int i = 0; i < UI_TIME_TEXT.Length; i++)
        {
            UI_TIME_TEXT[i].text = _time;
        }
        for (int i = 0; i < UI_DATE_TEXT.Length; i++)
        {
            UI_DATE_TEXT[i].text = _date;
        }
    }

    public void adjustTimeSpeedFaster()
    {
        secPerMin--;
    }

    public void adjustTimeSpeedSlower()
    {
        secPerMin++;
    }
}
