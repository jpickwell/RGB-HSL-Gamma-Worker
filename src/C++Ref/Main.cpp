#include <Windows.h>

int main()
{
  CopyMemory(UNALIGNED, NULL, 0);
  RtlCopyMemory(NULL, NULL, 0);
  memcpy(NULL, NULL, 0);
}
