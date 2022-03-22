using Sitecore.Diagnostics;

namespace LearnSc93Proj.Pipelines.logWriter
{
    public class logWriterProcessor
    {
        public void Process(LogWriterPipelineArgs args)
        {
            Log.Info(string.Format("+ Pipelines - Log Message Example: {0}", args.LogMessage), this);
        }
    }
}