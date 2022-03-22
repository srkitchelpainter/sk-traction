using Sitecore.Pipelines;

namespace LearnSc93Proj.Pipelines.logWriter
{
    public class LogWriterPipelineArgs : PipelineArgs
    {
        public string LogMessage { get; set; }
    }
}