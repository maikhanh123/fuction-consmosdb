using Microsoft.ProjectOxford.Face.Contract;

namespace PsHelloFunctions
{
    public class FaceAnalysisResults
    {
        public string ImageId { get; set; }
        public Face[] Faces { get; set; }
    }
}
