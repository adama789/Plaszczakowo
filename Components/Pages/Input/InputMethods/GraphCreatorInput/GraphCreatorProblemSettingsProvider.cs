using Plaszczakowo.Components.Pages.Input.InputMethods.GraphCreatorInput.Validator;

namespace Plaszczakowo.Components.Pages.Input.InputMethods.GraphCreatorInput;

public static class GraphCreatorProblemSettingsProvider
{
    public static GraphCreatorProblemSettings GetSettingsForProblem(string problemName)
    {
        return problemName switch
        {
            "guard_schedule" => GetSettingsForGuardSchedule(),
            "carrier_assignment" => GetSettingsForFenceTransport(),
            _ => throw new Exception($"Unknown {problemName} problemName.")
        };
    }

    private static GraphCreatorProblemSettings GetSettingsForGuardSchedule()
    {
        return new GraphCreatorProblemSettings()
        {
            DirectedGraph = true,
            CanChangeVertexValue = true,
            ReadGraphDataFromFenceState = true,
            Modes = GraphInputValidatorModes.HaveLoop
                    | GraphInputValidatorModes.OneEdgeFromEveryVertex
                    | GraphInputValidatorModes.EverythingConnected
                    | GraphInputValidatorModes.ShouldHave3Vertices
                    | GraphInputValidatorModes.ShouldHaveSpecialVertex
                    | GraphInputValidatorModes.EveryVertexShouldHaveValue
                    | GraphInputValidatorModes.VerticesShouldBeOnDifferentLines
        };
    }


    private static GraphCreatorProblemSettings GetSettingsForFenceTransport()
    {
        return new GraphCreatorProblemSettings()
        {
            DirectedGraph = false,
            CanChangeVertexValue = false,
            ReadGraphDataFromFenceState = false,
            Modes = GraphInputValidatorModes.EverythingConnected
                    | GraphInputValidatorModes.ShouldHave3Vertices
                    | GraphInputValidatorModes.ShouldHaveSpecialVertex
                    | GraphInputValidatorModes.VerticesShouldBeOnDifferentLines
        };
    }
}