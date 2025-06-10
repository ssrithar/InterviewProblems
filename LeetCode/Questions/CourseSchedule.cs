public class CourseSchedule
{
    public CourseSchedule()
    {
        int numCourses = 4;
        int[][] prerequisites = [[1,0],[2,0],[3,1],[3,2]];        

        bool canFinish = CanFinish(numCourses, prerequisites);
        Console.WriteLine($"Can finish all courses: {canFinish}");
    }

    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<int>[] graph = new List<int>[numCourses];
        int[] indegree = new int[numCourses];

        // Console.WriteLine($"Number of courses: {numCourses}");
        // Console.WriteLine($"Number of prerequisites: {prerequisites.Length}");
        // Console.WriteLine($"Length of first prerequisite: {prerequisites[0].Length}");
        // return false;

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var prerequisite in prerequisites)
        {
            int course = prerequisite[0];
            int preCourse = prerequisite[1];
            graph[preCourse].Add(course);
            indegree[course]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int count = 0;
        while (queue.Count > 0)
        {
            int course = queue.Dequeue();
            count++;

            foreach (var nextCourse in graph[course])
            {
                indegree[nextCourse]--;
                if (indegree[nextCourse] == 0)
                {
                    queue.Enqueue(nextCourse);
                }
            }
        }

        return count == numCourses;
    }
}