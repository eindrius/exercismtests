using System;

static class QuestLogic
{   
    public static bool CanFastAttack(bool knightIsAwake)
    {   
        //seta a variável em falso
        return knightIsAwake == false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //se qualquer um deles estiver dormindo, CanSpy == true.
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //retorna o archer == true e mantém prisoner == true
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {    
        //retorna true se o knight e o archer estão dormindo, o cachorro está presente e o
        //prisoner está acordado. Ou se está todo mundo acordado e o cachorro está presente.
        return (!knightIsAwake && !archerIsAwake && prisonerIsAwake) || (petDogIsPresent && !archerIsAwake);    
    }
}
