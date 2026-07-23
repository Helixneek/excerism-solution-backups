static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake ? false : true;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => (!archerIsAwake && prisonerIsAwake) ? true : false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent) {
            return archerIsAwake ? false : true;
        }
        else {
            return (prisonerIsAwake && !knightIsAwake && !archerIsAwake) ? true : false;
        }
    }
}
