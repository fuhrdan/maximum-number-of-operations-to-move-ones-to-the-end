//*****************************************************************************
//** 3228. Maximum Number of Operations to Move Ones to the End     leetcode **
//*****************************************************************************
//** A dance of ones through fields of naught,                               **
//** Each swap a step, precisely wrought.                                    **
//** They drift to rest where kin reside,                                    **
//** Four moves complete and the ones abide.                                 **
//*****************************************************************************

int maxOperations(char* s) {
    int retnum = 0;
    int count = 0;
    for(int i = 0; i < strlen(s); i++)
    {
        if(s[i] == '1') count++;
        else if (i && s[i - 1] == '1') retnum += count;
    }
    return retnum;
}