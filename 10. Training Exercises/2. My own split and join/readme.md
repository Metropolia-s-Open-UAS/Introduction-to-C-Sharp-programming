Here is a solution that avoids `string.Split` and `string.Join`.

The example output suggests the program reads a sentence, splits it on spaces, joins the pieces with commas, prints the joined string, and then prints each item on its own line.

```csharp
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static List<string> MySplit(string sentence, char separator)
    {
        List<string> result = new List<string>();
        StringBuilder current = new StringBuilder();

        foreach (char c in sentence)
        {
            if (c == separator)
            {
                result.Add(current.ToString());
                current.Clear();
            }
            else
            {
                current.Append(c);
            }
        }

        result.Add(current.ToString());
        return result;
    }

    static string MyJoin(List<string> items, char separator)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < items.Count; i++)
        {
            if (i > 0)
            {
                sb.Append(separator);
            }
            sb.Append(items[i]);
        }

        return sb.ToString();
    }

    static void Main(string[] args)
    {
        Console.Write("Please enter sentence: ");
        string sentence = Console.ReadLine();

        List<string> words = MySplit(sentence, ' ');

        Console.WriteLine(MyJoin(words, ','));

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
```

**How it works**

| Function | Logic |
|---|---|
| `MySplit` | Walks through each character. On the separator it saves the current word and starts a new one. After the loop it adds the last word. |
| `MyJoin` | Appends each item to a `StringBuilder`. It adds the separator before every item except the first. |

**Trace with `This is a sentence`**

| Step | Output |
|---|---|
| Prompt | `Please enter sentence: ` (no newline, input follows on the same line) |
| `MyJoin` result | `This,is,a,sentence` |
| Loop output | `This`, `is`, `a`, `sentence`, one per line |

**Notes for the strict comparison**

| Point | Detail |
|---|---|
| Prompt | Uses `Console.Write`, not `WriteLine`, so the input stays on the same line |
| Last word | The final `result.Add(...)` after the loop is required, otherwise `sentence` is lost |
| Output lines | Uses `WriteLine`, so each line ends with a newline as in the example |
