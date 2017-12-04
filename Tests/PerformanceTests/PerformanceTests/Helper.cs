using Entitas;

public static class Helper {

    public static IContext CreateContext() {
        return new Context(CP.NumComponents, 0, new ContextInfo("Test Context", new string[CP.NumComponents], null), (entity) => new SafeAERC(entity));
    }
}
