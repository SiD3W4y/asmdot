using System;
using System.Diagnostics;

namespace Asm.Net
{
    /// <summary>An ARM register.</summary>
    public struct Register
    {
        /// <summary>Underlying value.</summary>
        public readonly byte Value;

        /// <summary>Converts the wrapper to its underlying value.</summary>
        public static explicit operator byte(Register wrapper) => wrapper.Value;

        /// <summary>Wraps the given underlying value.</summary>
        public static explicit operator Register(byte value) => new Register { Value = value };

        public static readonly R0 = 0;
        public static readonly R1 = 1;
        public static readonly R2 = 2;
        public static readonly R3 = 3;
        public static readonly R4 = 4;
        public static readonly R5 = 5;
        public static readonly R6 = 6;
        public static readonly R7 = 7;
        public static readonly R8 = 8;
        public static readonly R9 = 9;
        public static readonly R10 = 10;
        public static readonly R11 = 11;
        public static readonly R12 = 12;
        public static readonly R13 = 13;
        public static readonly R14 = 14;
        public static readonly R15 = 15;
        public static readonly A1 = 0;
        public static readonly A2 = 1;
        public static readonly A3 = 2;
        public static readonly A4 = 3;
        public static readonly V1 = 4;
        public static readonly V2 = 5;
        public static readonly V3 = 6;
        public static readonly V4 = 7;
        public static readonly V5 = 8;
        public static readonly V6 = 9;
        public static readonly V7 = 10;
        public static readonly V8 = 11;
        public static readonly IP = 12;
        public static readonly SP = 13;
        public static readonly LR = 14;
        public static readonly PC = 15;
        public static readonly WR = 7;
        public static readonly SB = 9;
        public static readonly SL = 10;
        public static readonly FP = 11;
    }

    /// <summary>An ARM coprocessor.</summary>
    public struct Coprocessor
    {
        /// <summary>Underlying value.</summary>
        public readonly byte Value;

        /// <summary>Converts the wrapper to its underlying value.</summary>
        public static explicit operator byte(Coprocessor wrapper) => wrapper.Value;

        /// <summary>Wraps the given underlying value.</summary>
        public static explicit operator Coprocessor(byte value) => new Coprocessor { Value = value };

        public static readonly CP0 = 0;
        public static readonly CP1 = 1;
        public static readonly CP2 = 2;
        public static readonly CP3 = 3;
        public static readonly CP4 = 4;
        public static readonly CP5 = 5;
        public static readonly CP6 = 6;
        public static readonly CP7 = 7;
        public static readonly CP8 = 8;
        public static readonly CP9 = 9;
        public static readonly CP10 = 10;
        public static readonly CP11 = 11;
        public static readonly CP12 = 12;
        public static readonly CP13 = 13;
        public static readonly CP14 = 14;
        public static readonly CP15 = 15;
    }

    /// <summary>
    /// Condition for an ARM instruction to be executed.
    /// </summary>
    public enum Condition
    {
        /// <summary>
        /// Equal.
        /// </summary>
        EQ = 0,
        /// <summary>
        /// Not equal.
        /// </summary>
        NE = 1,
        /// <summary>
        /// Unsigned higher or same.
        /// </summary>
        HS = 2,
        /// <summary>
        /// Unsigned lower.
        /// </summary>
        LO = 3,
        /// <summary>
        /// Minus / negative.
        /// </summary>
        MI = 4,
        /// <summary>
        /// Plus / positive or zero.
        /// </summary>
        PL = 5,
        /// <summary>
        /// Overflow.
        /// </summary>
        VS = 6,
        /// <summary>
        /// No overflow.
        /// </summary>
        VC = 7,
        /// <summary>
        /// Unsigned higher.
        /// </summary>
        HI = 8,
        /// <summary>
        /// Unsigned lower or same.
        /// </summary>
        LS = 9,
        /// <summary>
        /// Signed greater than or equal.
        /// </summary>
        GE = 10,
        /// <summary>
        /// Signed less than.
        /// </summary>
        LT = 11,
        /// <summary>
        /// Signed greater than.
        /// </summary>
        GT = 12,
        /// <summary>
        /// Signed less than or equal.
        /// </summary>
        LE = 13,
        /// <summary>
        /// Always (unconditional).
        /// </summary>
        AL = 14,
        /// <summary>
        /// Unpredictable (ARMv4 or lower).
        /// </summary>
        UN = 15,
        /// <summary>
        /// Carry set.
        /// </summary>
        CS = 2,
        /// <summary>
        /// Carry clear.
        /// </summary>
        CC = 3,
    }

    /// <summary>
    /// Processor mode.
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// User mode.
        /// </summary>
        USR = 16,
        /// <summary>
        /// FIQ (high-speed data transfer) mode.
        /// </summary>
        FIQ = 17,
        /// <summary>
        /// IRQ (general-purpose interrupt handling) mode.
        /// </summary>
        IRQ = 18,
        /// <summary>
        /// Supervisor mode.
        /// </summary>
        SVC = 19,
        /// <summary>
        /// Abort mode.
        /// </summary>
        ABT = 23,
        /// <summary>
        /// Undefined mode.
        /// </summary>
        UND = 27,
        /// <summary>
        /// System (privileged) mode.
        /// </summary>
        SYS = 31,
    }

    /// <summary>
    /// Kind of a shift.
    /// </summary>
    public enum Shift
    {
        /// <summary>
        /// Logical shift left.
        /// </summary>
        LSL = 0,
        /// <summary>
        /// Logical shift right.
        /// </summary>
        LSR = 1,
        /// <summary>
        /// Arithmetic shift right.
        /// </summary>
        ASR = 2,
        /// <summary>
        /// Rotate right.
        /// </summary>
        ROR = 3,
        /// <summary>
        /// Shifted right by one bit.
        /// </summary>
        RRX = 3,
    }

    /// <summary>
    /// Kind of a right rotation.
    /// </summary>
    public enum Rotation
    {
        /// <summary>
        /// Do not rotate.
        /// </summary>
        NOP = 0,
        /// <summary>
        /// Rotate 8 bits to the right.
        /// </summary>
        ROR8 = 1,
        /// <summary>
        /// Rotate 16 bits to the right.
        /// </summary>
        ROR16 = 2,
        /// <summary>
        /// Rotate 24 bits to the right.
        /// </summary>
        ROR24 = 3,
    }

    /// <summary>
    /// Field mask bits.
    /// </summary>
    [Flags]
    public enum FieldMask
    {
        /// <summary>
        /// Control field mask bit.
        /// </summary>
        C = 1,
        /// <summary>
        /// Extension field mask bit.
        /// </summary>
        X = 2,
        /// <summary>
        /// Status field mask bit.
        /// </summary>
        S = 4,
        /// <summary>
        /// Flags field mask bit.
        /// </summary>
        F = 8,
    }

    /// <summary>
    /// Interrupt flags.
    /// </summary>
    [Flags]
    public enum InterruptFlags
    {
        /// <summary>
        /// FIQ interrupt bit.
        /// </summary>
        F = 1,
        /// <summary>
        /// IRQ interrupt bit.
        /// </summary>
        I = 2,
        /// <summary>
        /// Imprecise data abort bit.
        /// </summary>
        A = 4,
    }

    partial class Arm
    {
        /// <summary>Emits an 'adc' instruction.</summary>
        public static void adc(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((10485760 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'add' instruction.</summary>
        public static void add(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((8388608 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'and' instruction.</summary>
        public static void and(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((0 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'eor' instruction.</summary>
        public static void eor(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((2097152 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'orr' instruction.</summary>
        public static void orr(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((25165824 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'rsb' instruction.</summary>
        public static void rsb(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((6291456 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'rsc' instruction.</summary>
        public static void rsc(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((14680064 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sbc' instruction.</summary>
        public static void sbc(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((12582912 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sub' instruction.</summary>
        public static void sub(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((4194304 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'bkpt' instruction.</summary>
        public static void bkpt(ref void* buffer, ushort imm)
        {
            *(uint*)buf = 3776970864;
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'b' instruction.</summary>
        public static void b(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (167772160 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'bic' instruction.</summary>
        public static void bic(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((29360128 | cond) | (update_cprs << 20)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'blx' instruction.</summary>
        public static void blx(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (19922736 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'bx' instruction.</summary>
        public static void bx(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (19922704 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'bxj' instruction.</summary>
        public static void bxj(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (19922720 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'blxun' instruction.</summary>
        public static void blxun(ref void* buffer)
        {
            *(uint*)buf = 4194304000;
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'clz' instruction.</summary>
        public static void clz(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((24055568 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cmn' instruction.</summary>
        public static void cmn(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((24117248 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cmp' instruction.</summary>
        public static void cmp(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((22020096 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cpy' instruction.</summary>
        public static void cpy(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((27262976 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cps' instruction.</summary>
        public static void cps(ref void* buffer, Mode mode)
        {
            *(uint*)buf = (4043440128 | (mode << 0));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cpsie' instruction.</summary>
        public static void cpsie(ref void* buffer, InterruptFlags iflags)
        {
            *(uint*)buf = (4043833344 | (iflags << 6));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cpsid' instruction.</summary>
        public static void cpsid(ref void* buffer, InterruptFlags iflags)
        {
            *(uint*)buf = (4044095488 | (iflags << 6));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cpsie_mode' instruction.</summary>
        public static void cpsie_mode(ref void* buffer, InterruptFlags iflags, Mode mode)
        {
            *(uint*)buf = ((4043964416 | (iflags << 6)) | (mode << 0));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cpsid_mode' instruction.</summary>
        public static void cpsid_mode(ref void* buffer, InterruptFlags iflags, Mode mode)
        {
            *(uint*)buf = ((4044226560 | (iflags << 6)) | (mode << 0));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldc' instruction.</summary>
        public static void ldc(ref void* buffer, Condition cond, bool write, Register rn, Coprocessor cpnum)
        {
            *(uint*)buf = ((((202375168 | cond) | (write << 21)) | (rn << 16)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldm1' instruction.</summary>
        public static void ldm1(ref void* buffer, Condition cond, bool write, Register rn)
        {
            *(uint*)buf = (((135266304 | cond) | (write << 21)) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldm2' instruction.</summary>
        public static void ldm2(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((139460608 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldm3' instruction.</summary>
        public static void ldm3(ref void* buffer, Condition cond, bool write, Register rn)
        {
            *(uint*)buf = (((139493376 | cond) | (write << 21)) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldr' instruction.</summary>
        public static void ldr(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((68157440 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrb' instruction.</summary>
        public static void ldrb(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((72351744 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrbt' instruction.</summary>
        public static void ldrbt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((74448896 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrd' instruction.</summary>
        public static void ldrd(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((208 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrex' instruction.</summary>
        public static void ldrex(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((26218399 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrh' instruction.</summary>
        public static void ldrh(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((1048752 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrsb' instruction.</summary>
        public static void ldrsb(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((1048784 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrsh' instruction.</summary>
        public static void ldrsh(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((1048816 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ldrt' instruction.</summary>
        public static void ldrt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((70254592 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'cdp' instruction.</summary>
        public static void cdp(ref void* buffer, Condition cond, Coprocessor cpnum)
        {
            *(uint*)buf = ((234881024 | cond) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mcr' instruction.</summary>
        public static void mcr(ref void* buffer, Condition cond, Register rd, Coprocessor cpnum)
        {
            *(uint*)buf = (((234881040 | cond) | (rd << 12)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mrc' instruction.</summary>
        public static void mrc(ref void* buffer, Condition cond, Register rd, Coprocessor cpnum)
        {
            *(uint*)buf = (((235929616 | cond) | (rd << 12)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mcrr' instruction.</summary>
        public static void mcrr(ref void* buffer, Condition cond, Register rn, Register rd, Coprocessor cpnum)
        {
            *(uint*)buf = ((((205520896 | cond) | (rn << 16)) | (rd << 12)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mla' instruction.</summary>
        public static void mla(ref void* buffer, Condition cond, bool update_cprs, Register rn, Register rd)
        {
            *(uint*)buf = ((((2097296 | cond) | (update_cprs << 20)) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mov' instruction.</summary>
        public static void mov(ref void* buffer, Condition cond, bool update_cprs, Register rd)
        {
            *(uint*)buf = (((27262976 | cond) | (update_cprs << 20)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mrrc' instruction.</summary>
        public static void mrrc(ref void* buffer, Condition cond, Register rn, Register rd, Coprocessor cpnum)
        {
            *(uint*)buf = ((((206569472 | cond) | (rn << 16)) | (rd << 12)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mrs' instruction.</summary>
        public static void mrs(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((17760256 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mul' instruction.</summary>
        public static void mul(ref void* buffer, Condition cond, bool update_cprs, Register rd)
        {
            *(uint*)buf = (((144 | cond) | (update_cprs << 20)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'mvn' instruction.</summary>
        public static void mvn(ref void* buffer, Condition cond, bool update_cprs, Register rd)
        {
            *(uint*)buf = (((31457280 | cond) | (update_cprs << 20)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'msr_imm' instruction.</summary>
        public static void msr_imm(ref void* buffer, Condition cond, FieldMask fieldmask)
        {
            *(uint*)buf = ((52490240 | cond) | (fieldmask << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'msr_reg' instruction.</summary>
        public static void msr_reg(ref void* buffer, Condition cond, FieldMask fieldmask)
        {
            *(uint*)buf = ((18935808 | cond) | (fieldmask << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'pkhbt' instruction.</summary>
        public static void pkhbt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((109051920 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'pkhtb' instruction.</summary>
        public static void pkhtb(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((109051984 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'pld' instruction.</summary>
        public static void pld(ref void* buffer, Register rn)
        {
            *(uint*)buf = (4115722240 | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qadd' instruction.</summary>
        public static void qadd(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777296 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qadd16' instruction.</summary>
        public static void qadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764304 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qadd8' instruction.</summary>
        public static void qadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764432 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qaddsubx' instruction.</summary>
        public static void qaddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764336 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qdadd' instruction.</summary>
        public static void qdadd(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((20971600 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qdsub' instruction.</summary>
        public static void qdsub(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((23068752 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qsub' instruction.</summary>
        public static void qsub(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((18874448 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qsub16' instruction.</summary>
        public static void qsub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764400 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qsub8' instruction.</summary>
        public static void qsub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764528 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'qsubaddx' instruction.</summary>
        public static void qsubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((102764368 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'rev' instruction.</summary>
        public static void rev(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((113184560 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'rev16' instruction.</summary>
        public static void rev16(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((113184688 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'revsh' instruction.</summary>
        public static void revsh(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((117378992 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'rfe' instruction.</summary>
        public static void rfe(ref void* buffer, bool write, Register rn)
        {
            *(uint*)buf = ((4161800704 | (write << 21)) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sadd16' instruction.</summary>
        public static void sadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715728 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sadd8' instruction.</summary>
        public static void sadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715856 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'saddsubx' instruction.</summary>
        public static void saddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715760 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sel' instruction.</summary>
        public static void sel(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((109055920 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'setendbe' instruction.</summary>
        public static void setendbe(ref void* buffer)
        {
            *(uint*)buf = 4043375104;
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'setendle' instruction.</summary>
        public static void setendle(ref void* buffer)
        {
            *(uint*)buf = 4043374592;
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shadd16' instruction.</summary>
        public static void shadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103812880 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shadd8' instruction.</summary>
        public static void shadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103813008 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shaddsubx' instruction.</summary>
        public static void shaddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103812912 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shsub16' instruction.</summary>
        public static void shsub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103812976 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shsub8' instruction.</summary>
        public static void shsub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103813104 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'shsubaddx' instruction.</summary>
        public static void shsubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((103812944 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlabb' instruction.</summary>
        public static void smlabb(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777344 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlabt' instruction.</summary>
        public static void smlabt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777376 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlatb' instruction.</summary>
        public static void smlatb(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777408 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlatt' instruction.</summary>
        public static void smlatt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777440 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlad' instruction.</summary>
        public static void smlad(ref void* buffer, Condition cond, bool exchange, Register rn, Register rd)
        {
            *(uint*)buf = ((((117440528 | cond) | (exchange << 5)) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlal' instruction.</summary>
        public static void smlal(ref void* buffer, Condition cond, bool update_cprs)
        {
            *(uint*)buf = ((14680208 | cond) | (update_cprs << 20));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlalbb' instruction.</summary>
        public static void smlalbb(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (20971648 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlalbt' instruction.</summary>
        public static void smlalbt(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (20971680 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlaltb' instruction.</summary>
        public static void smlaltb(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (20971712 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlaltt' instruction.</summary>
        public static void smlaltt(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (20971744 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlald' instruction.</summary>
        public static void smlald(ref void* buffer, Condition cond, bool exchange)
        {
            *(uint*)buf = ((121634832 | cond) | (exchange << 5));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlawb' instruction.</summary>
        public static void smlawb(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((18874496 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlawt' instruction.</summary>
        public static void smlawt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((18874560 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlsd' instruction.</summary>
        public static void smlsd(ref void* buffer, Condition cond, bool exchange, Register rn, Register rd)
        {
            *(uint*)buf = ((((117440592 | cond) | (exchange << 5)) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smlsld' instruction.</summary>
        public static void smlsld(ref void* buffer, Condition cond, bool exchange)
        {
            *(uint*)buf = ((121634896 | cond) | (exchange << 5));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smmla' instruction.</summary>
        public static void smmla(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((122683408 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smmls' instruction.</summary>
        public static void smmls(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((122683600 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smmul' instruction.</summary>
        public static void smmul(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((122744848 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smuad' instruction.</summary>
        public static void smuad(ref void* buffer, Condition cond, bool exchange, Register rd)
        {
            *(uint*)buf = (((117501968 | cond) | (exchange << 5)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smulbb' instruction.</summary>
        public static void smulbb(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((23068800 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smulbt' instruction.</summary>
        public static void smulbt(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((23068832 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smultb' instruction.</summary>
        public static void smultb(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((23068864 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smultt' instruction.</summary>
        public static void smultt(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((23068896 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smull' instruction.</summary>
        public static void smull(ref void* buffer, Condition cond, bool update_cprs)
        {
            *(uint*)buf = ((12583056 | cond) | (update_cprs << 20));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smulwb' instruction.</summary>
        public static void smulwb(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((18874528 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smulwt' instruction.</summary>
        public static void smulwt(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((18874592 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'smusd' instruction.</summary>
        public static void smusd(ref void* buffer, Condition cond, bool exchange, Register rd)
        {
            *(uint*)buf = (((117502032 | cond) | (exchange << 5)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'srs' instruction.</summary>
        public static void srs(ref void* buffer, bool write, Mode mode)
        {
            *(uint*)buf = ((4165797120 | (write << 21)) | (mode << 0));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ssat' instruction.</summary>
        public static void ssat(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((105906192 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ssat16' instruction.</summary>
        public static void ssat16(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((111152944 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ssub16' instruction.</summary>
        public static void ssub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715824 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ssub8' instruction.</summary>
        public static void ssub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715952 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'ssubaddx' instruction.</summary>
        public static void ssubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((101715792 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'stc' instruction.</summary>
        public static void stc(ref void* buffer, Condition cond, bool write, Register rn, Coprocessor cpnum)
        {
            *(uint*)buf = ((((201326592 | cond) | (write << 21)) | (rn << 16)) | (cpnum << 8));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'stm1' instruction.</summary>
        public static void stm1(ref void* buffer, Condition cond, bool write, Register rn)
        {
            *(uint*)buf = (((134217728 | cond) | (write << 21)) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'stm2' instruction.</summary>
        public static void stm2(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((138412032 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'str' instruction.</summary>
        public static void str(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((67108864 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strb' instruction.</summary>
        public static void strb(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((71303168 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strbt' instruction.</summary>
        public static void strbt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((73400320 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strd' instruction.</summary>
        public static void strd(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((240 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strex' instruction.</summary>
        public static void strex(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((25169808 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strh' instruction.</summary>
        public static void strh(ref void* buffer, Condition cond, bool write, Register rn, Register rd)
        {
            *(uint*)buf = ((((176 | cond) | (write << 21)) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'strt' instruction.</summary>
        public static void strt(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((69206016 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'swi' instruction.</summary>
        public static void swi(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (251658240 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'swp' instruction.</summary>
        public static void swp(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((16777360 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'swpb' instruction.</summary>
        public static void swpb(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((20971664 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxtab' instruction.</summary>
        public static void sxtab(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((111149168 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxtab16' instruction.</summary>
        public static void sxtab16(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((109052016 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxtah' instruction.</summary>
        public static void sxtah(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((112197744 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxtb' instruction.</summary>
        public static void sxtb(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((112132208 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxtb16' instruction.</summary>
        public static void sxtb16(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((110035056 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'sxth' instruction.</summary>
        public static void sxth(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((113180784 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'teq' instruction.</summary>
        public static void teq(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((19922944 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits a 'tst' instruction.</summary>
        public static void tst(ref void* buffer, Condition cond, Register rn)
        {
            *(uint*)buf = ((17825792 | cond) | (rn << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uadd16' instruction.</summary>
        public static void uadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910032 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uadd8' instruction.</summary>
        public static void uadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910160 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uaddsubx' instruction.</summary>
        public static void uaddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910064 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhadd16' instruction.</summary>
        public static void uhadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007184 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhadd8' instruction.</summary>
        public static void uhadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007312 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhaddsubx' instruction.</summary>
        public static void uhaddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007216 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhsub16' instruction.</summary>
        public static void uhsub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007280 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhsub8' instruction.</summary>
        public static void uhsub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007408 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uhsubaddx' instruction.</summary>
        public static void uhsubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((108007248 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'umaal' instruction.</summary>
        public static void umaal(ref void* buffer, Condition cond)
        {
            *(uint*)buf = (4194448 | cond);
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'umlal' instruction.</summary>
        public static void umlal(ref void* buffer, Condition cond, bool update_cprs)
        {
            *(uint*)buf = ((10485904 | cond) | (update_cprs << 20));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'umull' instruction.</summary>
        public static void umull(ref void* buffer, Condition cond, bool update_cprs)
        {
            *(uint*)buf = ((8388752 | cond) | (update_cprs << 20));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqadd16' instruction.</summary>
        public static void uqadd16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958608 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqadd8' instruction.</summary>
        public static void uqadd8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958736 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqaddsubx' instruction.</summary>
        public static void uqaddsubx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958640 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqsub16' instruction.</summary>
        public static void uqsub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958704 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqsub8' instruction.</summary>
        public static void uqsub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958832 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uqsubaddx' instruction.</summary>
        public static void uqsubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((106958672 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usad8' instruction.</summary>
        public static void usad8(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((125890576 | cond) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usada8' instruction.</summary>
        public static void usada8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((125829136 | cond) | (rn << 12)) | (rd << 16));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usat' instruction.</summary>
        public static void usat(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((115343376 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usat16' instruction.</summary>
        public static void usat16(ref void* buffer, Condition cond, Register rd)
        {
            *(uint*)buf = ((115347248 | cond) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usub16' instruction.</summary>
        public static void usub16(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910128 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usub8' instruction.</summary>
        public static void usub8(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910256 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'usubaddx' instruction.</summary>
        public static void usubaddx(ref void* buffer, Condition cond, Register rn, Register rd)
        {
            *(uint*)buf = (((105910096 | cond) | (rn << 16)) | (rd << 12));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxtab' instruction.</summary>
        public static void uxtab(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((115343472 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxtab16' instruction.</summary>
        public static void uxtab16(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((113246320 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxtah' instruction.</summary>
        public static void uxtah(ref void* buffer, Condition cond, Register rn, Register rd, Rotation rotate)
        {
            *(uint*)buf = ((((116392048 | cond) | (rn << 16)) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxtb' instruction.</summary>
        public static void uxtb(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((116326512 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxtb16' instruction.</summary>
        public static void uxtb16(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((114229360 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }

        /// <summary>Emits an 'uxth' instruction.</summary>
        public static void uxth(ref void* buffer, Condition cond, Register rd, Rotation rotate)
        {
            *(uint*)buf = (((117375088 | cond) | (rd << 12)) | (rotate << 10));
            (byte*)buf += 4;
        }


    }
}