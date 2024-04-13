using Unluau.Chunk;
using Unluau.IL.Visitors;


public class CmdOption
{
    public string[] Triggers;
    public string Description { get; }
    public int ArgCount { get; } // The command
    public Action Func { get; } // The function that should run

    // Constructor
    public CmdOption(string[] Triggers, string Description, int ArgCount = 0, Action Func = null)
    {
        this.Triggers = Triggers;
        this.Description = Description;
        this.ArgCount = ArgCount;
        this.Func = Func;
    }
}


// Command Line Options
public class CmdOptions
{
    // Storage of Options
    public List<CmdOption> Options;

    // Add a CLI Option
    public void Add( CmdOption option ) { 
        Options.Add( option );
    }
}


namespace Unluau.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new CmdOption(
                Triggers: ["-h", "--help"],
                Description: "We amongus"
            );

            // Note, an arg wrapped around "" counts as one arg.
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }


            /*using var stream = File.OpenRead("./test/Upvalue03.luau");
            var chunk = LuauChunk.Create(stream);

            Console.WriteLine(chunk.ToString());
            var program = chunk.Lift();

            using var output = Console.OpenStandardOutput();

            program.Visit(new ValueVisitor());
            program.Visit(new OutputVisitor(output));*/
        }
    }
}
