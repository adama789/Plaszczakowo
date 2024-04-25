// namespace Problem.HuffmanCoding;
//
// public class HuffmanCodingResolver :
//     ProblemResolver<HuffmanCodingInputData, HuffmanCodingOutput>
// {
//     public Dictionary<char, int> CalculateAppearances(string phrase)
//     {
//         Dictionary<char, int> letterAppearances = new();
//         for (int i = 0; i < phrase.Length; i++)
//         {
//             if (letterAppearances.ContainsKey(phrase[i]))
//             {
//                 letterAppearances[phrase[i]]++;
//             } else
//             {
//                 letterAppearances.Add(phrase[i], 1);
//             }
//         }
//         return letterAppearances;
//     }
//
//     public void GenerateHuffmanTree(Dictionary<char, int> letterAppearances, ref List<HuffmanCodingOutput> outputSteps)
//     {
//         HuffmanTree huffmanTree = new HuffmanTree();
//         Dictionary<char, string> dict = new Dictionary<char, string>();
//         Node root = huffmanTree.CreateHuffmanTree(letterAppearances, ref outputSteps);
//         outputSteps[0].HuffmanTree = root;
//         GenerateTree(ref outputSteps, huffmanTree);
//     }
//
//     public void GenerateTree(ref List<HuffmanCodingOutput> output, HuffmanTree huffmanTree)
//     {
//         huffmanTree.GenerateDictionary(output[0].HuffmanTree, "", output[0].HuffmanDictionary);
//     }
//     public override List<HuffmanCodingOutput> Resolve(HuffmanCodingInputData data)
//     {
//         HuffmanCodingInputData correction = new HuffmanCodingInputData(data.InputPhrase);
//         List<HuffmanCodingOutput> outputSteps = new List<HuffmanCodingOutput>();
//         HuffmanCodingOutput computerScienceMachineOutput = new HuffmanCodingOutput();
//         outputSteps.Add(computerScienceMachineOutput);
//         
//
//         Dictionary<char, int> letterAppearances = new Dictionary<char, int>();
//         
//         outputSteps[0].LetterAppearances = CalculateAppearances(data.InputPhrase);
//
//         GenerateHuffmanTree(outputSteps[0].LetterAppearances, ref outputSteps);
//
//         return outputSteps;
//     }
//
//     
//
//
// }