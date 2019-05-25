using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "course start")
                {
                    break;
                }
                List<string> inputCommand = input
                                            .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

                string command = inputCommand[0];
                string lessonTitle = inputCommand[1];

                switch (command)
                {
                    case "Add":
                        AddLesson(lessonTitle, lessons);
                        break;
                    case "Insert":
                        int indexToInsertAt = int.Parse(inputCommand[2]);
                        InsertLesson(lessonTitle, indexToInsertAt, lessons);
                        break;
                    case "Remove":
                        Remove(lessonTitle, lessons);
                        break;
                    case "Swap":
                        string lessonTitleToSwap = inputCommand[2];
                        SwapLessons(lessonTitle, lessonTitleToSwap, lessons);
                        break;
                    case "Exercise":
                        Exercise(lessonTitle, lessons);
                        break;
                    default: break;
                }
            }

            PrintSchedule(lessons);
        }

        private static void SwapLessons(string lessonTitle, string lessonTitleToSwap, List<string> lessons)
        {
            int indexLesson1 = -1;
            int indexLesson2 = -1;
            string exerciseTitle1 = lessonTitle + "-Exercise";
            string exerciseTitle2 = lessonTitleToSwap + "-Exercise";

            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    indexLesson1 = i;
                }
                if (lessons[i] == lessonTitleToSwap)
                {
                    indexLesson2 = i;
                }
            }

            if (indexLesson1 >= 0 && indexLesson2 >= 0)
            {
                Swap(indexLesson1, indexLesson2, lessons);
            }

            if (indexLesson1 + 1 <= lessons.Count - 1
                && indexLesson2 + 1 <= lessons.Count - 1
                && lessons[indexLesson1 + 1] == exerciseTitle1
                && lessons[indexLesson2 + 1] == exerciseTitle2)
            {
                Swap(indexLesson1 + 1, indexLesson2 + 1, lessons);
            }
            else if (indexLesson1 + 1 <= lessons.Count - 1
                && lessons[indexLesson1 + 1] == exerciseTitle1)
            {
                string temp = exerciseTitle1;
                lessons.RemoveAt(indexLesson1 + 1);
                lessons.Insert(indexLesson2 + 1, exerciseTitle1);
            }
            else if (indexLesson2 + 1 <= lessons.Count - 1
                && lessons[indexLesson2 + 1] == exerciseTitle2)
            {
                string temp = exerciseTitle2;
                lessons.RemoveAt(indexLesson2 + 1);
                lessons.Insert(indexLesson1 + 1, exerciseTitle2);

            }

        }

        private static void Swap(int index1, int index2, List<string> lessons)
        {
            string temp = lessons[index1];
            lessons[index1] = lessons[index2];
            lessons[index2] = temp;
        }

        private static void Remove(string lessonTitle, List<string> lessons)
        {
            bool isLessonExist = false;
            int indexLesson = -1;
            string exerciseTitle = lessonTitle + "-Exercise";
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    isLessonExist = true;
                    indexLesson = i;
                }
            }

            if (isLessonExist && indexLesson >= 0)
            {
                if ((indexLesson + 1) <= lessons.Count - 1
                    && lessons[indexLesson + 1] == exerciseTitle)
                {
                    lessons.RemoveAt(indexLesson + 1);
                    lessons.RemoveAt(indexLesson);
                }
                else
                {
                    lessons.RemoveAt(indexLesson);
                }
            }
        }

        private static void Exercise(string lessonTitle, List<string> lessons)
        {
            bool isLessonExist = false;
            int indexLesson = -1;
            string exerciseTitle = lessonTitle + "-Exercise";
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    isLessonExist = true;
                    indexLesson = i;
                }
            }
            if (isLessonExist)
            {
                if ((indexLesson + 1) <= lessons.Count - 1
                    && lessons[indexLesson + 1] == exerciseTitle)
                {
                    return;
                }
                else
                {
                    lessons.Insert(indexLesson + 1, exerciseTitle);
                }
            }
            else
            {
                lessons.Add(lessonTitle);
                lessons.Add(exerciseTitle);
            }
        }

        private static void InsertLesson(string lessonTitle, int indexToInsertAt, List<string> lessons)
        {
            bool isLessonExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    isLessonExist = true;
                }
            }
            if (!isLessonExist && indexToInsertAt >= 0 && indexToInsertAt < lessons.Count)
            {
                lessons.Insert(indexToInsertAt, lessonTitle);
            }
        }

        private static void AddLesson(string lessonTitle, List<string> lessons)
        {
            bool isLessonExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == lessonTitle)
                {
                    isLessonExist = true;
                }
            }
            if (!isLessonExist)
            {
                lessons.Add(lessonTitle);
            }
        }

        private static void PrintSchedule(List<string> lessons)
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
