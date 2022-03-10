
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly lesson4_3
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 09 6C 65 73 73 6F 6E 34 5F 33 00 00 )       // ...lesson4_3..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 09 6C 65 73 73 6F 6E 34 5F 33 00 00 )       // ...lesson4_3..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 09 6C 65 73 73 6F 6E 34 5F 33 00 00 )       // ...lesson4_3..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module lesson4_3.dll
// MVID: {F4265C3D-2AC7-4B2D-8E7C-88A1D798AA7D}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x09480000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit lesson4_3.Program
       extends [System.Runtime]System.Object
{
  .class auto ansi sealed nested private Seasons
         extends [System.Runtime]System.Enum
  {
    .field public specialname rtspecialname int32 value__
    .field public static literal valuetype lesson4_3.Program/Seasons Winter = int32(0x00000000)
    .field public static literal valuetype lesson4_3.Program/Seasons Spring = int32(0x00000001)
    .field public static literal valuetype lesson4_3.Program/Seasons Summer = int32(0x00000002)
    .field public static literal valuetype lesson4_3.Program/Seasons Autumn = int32(0x00000003)
  } // end of class Seasons

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       83 (0x53)
    .maxstack  2
    .locals init (int32 V_0,
             bool V_1,
             string V_2)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    47 04 38 04 41 04 3B 04 3E 04 20 00 3E 04 42 04   // G.8.A.;.>. .>.B.
                                    20 00 31 00 20 00 34 04 3E 04 20 00 31 00 32 00 ) //  .1. .4.>. .1.2.
    IL_0006:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  call       string [System.Console]System.Console::ReadLine()
    IL_0011:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_0016:  stloc.0
    IL_0017:  ldloc.0
    IL_0018:  ldc.i4.s   13
    IL_001a:  bge.s      IL_0022

    IL_001c:  ldloc.0
    IL_001d:  ldc.i4.0
    IL_001e:  cgt
    IL_0020:  br.s       IL_0023

    IL_0022:  ldc.i4.0
    IL_0023:  stloc.1
    IL_0024:  ldloc.1
    IL_0025:  brtrue.s  IL_0046

    IL_0027:  nop
    IL_0028:  ldstr      bytearray (12 04 30 04 48 04 20 00 3C 04 35 04 41 04 4F 04   // ..0.H. .<.5.A.O.
                                    46 04 )                                           // F.
    IL_002d:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0032:  nop
    IL_0033:  ldloc.0
    IL_0034:  ldloca.s   V_2
    IL_0036:  call       void lesson4_3.Program::'<Main>g__GetSeason|1_0'(int32,
                                                                          string&)
    IL_003b:  nop
    IL_003c:  ldloc.2
    IL_003d:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0042:  nop
    IL_0043:  nop
    IL_0044:  br.s       IL_0051

    IL_0046:  ldstr      bytearray (1E 04 48 04 38 04 31 04 3A 04 30 04 3A 00 20 00   // ..H.8.1.:.0.:. .
                                    32 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // 2.2.5.4.8.B.5. .
                                    47 04 38 04 41 04 3B 04 3E 04 20 00 3E 04 42 04   // G.8.A.;.>. .>.B.
                                    20 00 31 00 20 00 34 04 3E 04 20 00 31 00 32 00 ) //  .1. .4.>. .1.2.
    IL_004b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0050:  nop
    IL_0051:  nop
    IL_0052:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

  .method assembly hidebysig static void 
          '<Main>g__GetSeason|1_0'(int32 number,
                                   [out] string& season) cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       147 (0x93)
    .maxstack  2
    .locals init (int32 V_0,
             int32 V_1,
             valuetype lesson4_3.Program/Seasons V_2)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldstr      ""
    IL_0007:  stind.ref
    IL_0008:  ldarg.0
    IL_0009:  stloc.1
    IL_000a:  ldloc.1
    IL_000b:  stloc.0
    IL_000c:  ldloc.0
    IL_000d:  ldc.i4.1
    IL_000e:  sub
    IL_000f:  switch     ( 
                          IL_0046,
                          IL_0046,
                          IL_0059,
                          IL_0059,
                          IL_0059,
                          IL_006c,
                          IL_006c,
                          IL_006c,
                          IL_007f,
                          IL_007f,
                          IL_007f,
                          IL_0046)
    IL_0044:  br.s       IL_0092

    IL_0046:  ldarg.1
    IL_0047:  ldc.i4.0
    IL_0048:  stloc.2
    IL_0049:  ldloca.s   V_2
    IL_004b:  constrained. lesson4_3.Program/Seasons
    IL_0051:  callvirt   instance string [System.Runtime]System.Object::ToString()
    IL_0056:  stind.ref
    IL_0057:  br.s       IL_0092

    IL_0059:  ldarg.1
    IL_005a:  ldc.i4.1
    IL_005b:  stloc.2
    IL_005c:  ldloca.s   V_2
    IL_005e:  constrained. lesson4_3.Program/Seasons
    IL_0064:  callvirt   instance string [System.Runtime]System.Object::ToString()
    IL_0069:  stind.ref
    IL_006a:  br.s       IL_0092

    IL_006c:  ldarg.1
    IL_006d:  ldc.i4.2
    IL_006e:  stloc.2
    IL_006f:  ldloca.s   V_2
    IL_0071:  constrained. lesson4_3.Program/Seasons
    IL_0077:  callvirt   instance string [System.Runtime]System.Object::ToString()
    IL_007c:  stind.ref
    IL_007d:  br.s       IL_0092

    IL_007f:  ldarg.1
    IL_0080:  ldc.i4.3
    IL_0081:  stloc.2
    IL_0082:  ldloca.s   V_2
    IL_0084:  constrained. lesson4_3.Program/Seasons
    IL_008a:  callvirt   instance string [System.Runtime]System.Object::ToString()
    IL_008f:  stind.ref
    IL_0090:  br.s       IL_0092

    IL_0092:  ret
  } // end of method Program::'<Main>g__GetSeason|1_0'

} // end of class lesson4_3.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\mdtulaev\source\repos\lesson7\lesson4_3_Ildasm\IL code.res
