using System;

namespace Essential5_4
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] valueUkrainian = new string[5];
        private string[] valueEnglish = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; valueUkrainian[0] = "книжка"; valueEnglish[0] = "book";
            key[1] = "стул"; valueUkrainian[1] = "стілець"; valueEnglish[1] = "chair";
            key[2] = "солнце"; valueUkrainian[2] = "сонце"; valueEnglish[2] = "sun";
            key[3] = "яблоко"; valueUkrainian[3] = "яблуко"; valueEnglish[3] = "apple";
            key[4] = "стол"; valueUkrainian[4] = "стіл"; valueEnglish[4] = "table";
        }

        public string this[string index, string language]
        {
            get
            {
                switch (language.ToLower())
                {
                    case "русский":
                        for (int i = 0; i < key.Length; i++)
                        {
                            if (key[i] == index)
                            {
                                return $"{key[i]} - {valueUkrainian[i]} - {valueEnglish[i]}";
                            }
                        }
                        break;
                    case "english":
                        for (int i = 0; i < valueEnglish.Length; i++)
                        {
                            if (valueEnglish[i] == index)
                            {
                                return $"{valueEnglish[i]} - {valueUkrainian[i]} - {key[i]}";
                            }
                        }
                        break;
                    case "українська":
                        for (int i = 0; i < valueUkrainian.Length; i++)
                        {
                            if (valueUkrainian[i] == index)
                            {
                                return $"{valueUkrainian[i]} - {key[i]} - {valueEnglish[i]}";
                            }
                        }
                        break;
                    default:
                        return "Невірно вказана мова.";
                }

                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index, string language]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    switch (language.ToLower())
                    {
                        case "english":
                            return $"{key[index]} - {valueUkrainian[index]} - {valueEnglish[index]}";
                        case "українська":
                            return $"{key[index]} - {valueEnglish[index]} - {valueUkrainian[index]}";
                        case "русский":
                            return $"{key[index]} - {valueUkrainian[index]} - {valueEnglish[index]}";
                        default:
                            return "Невірно вказана мова.";
                    }
                }
                else
                {
                    return "Спроба звернення за межі масиву.";
                }
            }
        }
    }
}
