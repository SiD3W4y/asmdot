// Automatically generated file.

#include <stdint.h>

#define byte unsigned char
#define bool _Bool
#define CALLCONV 



#define reg byte

///
/// Condition for an ARM instruction to be executed.
typedef enum {
    ///
    /// Equal.
    EQ = 0b0000,
    ///
    /// Not equal.
    NE = 0b0001,
    ///
    /// Carry set.
    CS = 0b0010,
    ///
    /// Unsigned higher or same.
    HS = 0b0010,
    ///
    /// Carry clear.
    CC = 0b0011,
    ///
    /// Unsigned lower.
    LO = 0b0011,
    ///
    /// Minus / negative.
    MI = 0b0100,
    ///
    /// Plus / positive or zero.
    PL = 0b0101,
    ///
    /// Overflow.
    VS = 0b0110,
    ///
    /// No overflow.
    VC = 0b0111,
    ///
    /// Unsigned higher.
    HI = 0b1000,
    ///
    /// Unsigned lower or same.
    LS = 0b1001,
    ///
    /// Signed greater than or equal.
    GE = 0b1010,
    ///
    /// Signed less than.
    LT = 0b1011,
    ///
    /// Signed greater than.
    GT = 0b1100,
    ///
    /// Signed less than or equal.
    LE = 0b1101,
    ///
    /// Always (unconditional).
    AL = 0b1110,
    ///
    /// Unpredictable (ARMv4 and lower) or unconditional (ARMv5 and higher).
    UN = 0b1111
} Condition;

///
/// Processor mode.
typedef enum {
    ///
    /// User mode.
    USR = 0b10000,
    ///
    /// FIQ (high-speed data transfer) mode.
    FIQ = 0b10001,
    ///
    /// IRQ (general-purpose interrupt handling) mode.
    IRQ = 0b10010,
    ///
    /// Supervisor mode.
    SVC = 0b10011,
    ///
    /// Abort mode.
    ABT = 0b10111,
    ///
    /// Undefined mode.
    UND = 0b11011,
    ///
    /// System (privileged) mode.
    SYS = 0b11111
} Mode;

///
/// Kind of a shift.
typedef enum {
    ///
    /// Logical shift left.
    LSL = 0b00,
    ///
    /// Logical shift right.
    LSR = 0b01,
    ///
    /// Arithmetic shift right.
    ASR = 0b10,
    ///
    /// Rotate right.
    ROR = 0b11,
    ///
    /// Shifted right by one bit.
    RRX = 0b11
} Shift;

///
/// Kind of a right rotation.
typedef enum {
    ///
    /// Rotate 8 bits to the right.
    ROR8  = 0b01,
    ///
    /// Rotate 16 bits to the right.
    ROR16 = 0b10,
    ///
    /// Rotate 24 bits to the right.
    ROR24 = 0b11,
    ///
    /// Do not rotate.
    NOP   = 0b00
} Rotation;

///
/// Field mask bits.
typedef enum {
    ///
    /// Control field mask bit.
    C = 0b0001,
    ///
    /// Extension field mask bit.
    X = 0b0010,
    ///
    /// Status field mask bit.
    S = 0b0100,
    ///
    /// Flags field mask bit.
    F = 0b1000
} Field;

///
/// Interrupt flags.
typedef enum {
    ///
    /// Imprecise data abort bit.
    A = 0b100,
    ///
    /// IRQ interrupt bit.
    I = 0b010,
    ///
    /// FIQ interrupt bit.
    F = 0b001
} InterruptFlags;

void CALLCONV adc(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV add(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV and(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV eor(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV orr(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV rsb(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV rsc(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV sbc(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV sub(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV bkpt(void** buf);
void CALLCONV b(void** buf, Condition cond);
void CALLCONV bic(void** buf, Condition cond, bool i, bool s, Reg rn, Reg rd);
void CALLCONV blx(void** buf, Condition cond);
void CALLCONV bx(void** buf, Condition cond);
void CALLCONV bxj(void** buf, Condition cond);
void CALLCONV blxun(void** buf);
void CALLCONV cdp(void** buf, Condition cond);
void CALLCONV clz(void** buf, Condition cond, Reg rd);
void CALLCONV cmn(void** buf, Condition cond, bool i, Reg rn);
void CALLCONV cmp(void** buf, Condition cond, bool i, Reg rn);
void CALLCONV cpy(void** buf, Condition cond, Reg rd);
void CALLCONV cps(void** buf, Mode mode);
void CALLCONV cpsie(void** buf);
void CALLCONV cpsid(void** buf);
void CALLCONV cpsie_mode(void** buf, Mode mode);
void CALLCONV cpsid_mode(void** buf, Mode mode);
void CALLCONV ldc(void** buf, Condition cond, bool write, Reg rn);
void CALLCONV ldm1(void** buf, Condition cond, bool write, Reg rn);
void CALLCONV ldm2(void** buf, Condition cond, Reg rn);
void CALLCONV ldm3(void** buf, Condition cond, bool write, Reg rn);
void CALLCONV ldr(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrb(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrbt(void** buf, Condition cond, bool i, Reg rn, Reg rd);
void CALLCONV ldrd(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrex(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV ldrh(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrsb(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrsh(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV ldrt(void** buf, Condition cond, bool i, Reg rn, Reg rd);
void CALLCONV mcr(void** buf, Condition cond, Reg rd);
void CALLCONV mcrr(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV mla(void** buf, Condition cond, bool s, Reg rn, Reg rd);
void CALLCONV mov(void** buf, Condition cond, bool i, bool s, Reg rd);
void CALLCONV mrc(void** buf, Condition cond, Reg rd);
void CALLCONV mrrc(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV mrs(void** buf, Condition cond, Reg rd);
void CALLCONV mul(void** buf, Condition cond, bool s, Reg rd);
void CALLCONV mvn(void** buf, Condition cond, bool i, bool s, Reg rd);
void CALLCONV msr_imm(void** buf, Condition cond);
void CALLCONV msr_reg(void** buf, Condition cond);
void CALLCONV pkhbt(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV pkhtb(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV pld(void** buf, bool i, Reg rn);
void CALLCONV qadd(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qaddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qdadd(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qdsub(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qsub(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qsub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qsub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV qsubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV rev(void** buf, Condition cond, Reg rd);
void CALLCONV rev16(void** buf, Condition cond, Reg rd);
void CALLCONV revsh(void** buf, Condition cond, Reg rd);
void CALLCONV rfe(void** buf, bool write, Reg rn);
void CALLCONV sadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV saddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sel(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV setendbe(void** buf);
void CALLCONV setendle(void** buf);
void CALLCONV shadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV shadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV shaddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV shsub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV shsub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV shsubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlabb(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlabt(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlatb(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlatt(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlad(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlal(void** buf, Condition cond, bool s);
void CALLCONV smlalbb(void** buf, Condition cond);
void CALLCONV smlalbt(void** buf, Condition cond);
void CALLCONV smlaltb(void** buf, Condition cond);
void CALLCONV smlaltt(void** buf, Condition cond);
void CALLCONV smlald(void** buf, Condition cond);
void CALLCONV smlawb(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlawt(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlsd(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smlsld(void** buf, Condition cond);
void CALLCONV smmla(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smmls(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV smmul(void** buf, Condition cond, Reg rd);
void CALLCONV smuad(void** buf, Condition cond, Reg rd);
void CALLCONV smulbb(void** buf, Condition cond, Reg rd);
void CALLCONV smulbt(void** buf, Condition cond, Reg rd);
void CALLCONV smultb(void** buf, Condition cond, Reg rd);
void CALLCONV smultt(void** buf, Condition cond, Reg rd);
void CALLCONV smull(void** buf, Condition cond, bool s);
void CALLCONV smulwb(void** buf, Condition cond, Reg rd);
void CALLCONV smulwt(void** buf, Condition cond, Reg rd);
void CALLCONV smusd(void** buf, Condition cond, Reg rd);
void CALLCONV srs(void** buf, bool write, Mode mode);
void CALLCONV ssat(void** buf, Condition cond, Reg rd);
void CALLCONV ssat16(void** buf, Condition cond, Reg rd);
void CALLCONV ssub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV ssub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV ssubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV stc(void** buf, Condition cond, bool write, Reg rn);
void CALLCONV stm1(void** buf, Condition cond, bool write, Reg rn);
void CALLCONV stm2(void** buf, Condition cond, Reg rn);
void CALLCONV str(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV strb(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV strbt(void** buf, Condition cond, bool i, Reg rn, Reg rd);
void CALLCONV strd(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV strex(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV strh(void** buf, Condition cond, bool write, bool i, Reg rn, Reg rd);
void CALLCONV strt(void** buf, Condition cond, bool i, Reg rn, Reg rd);
void CALLCONV swi(void** buf, Condition cond);
void CALLCONV swp(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV swpb(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sxtab(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sxtab16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sxtah(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV sxtb(void** buf, Condition cond, Reg rd);
void CALLCONV sxtb16(void** buf, Condition cond, Reg rd);
void CALLCONV sxth(void** buf, Condition cond, Reg rd);
void CALLCONV teq(void** buf, Condition cond, bool i, Reg rn);
void CALLCONV tst(void** buf, Condition cond, bool i, Reg rn);
void CALLCONV uadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uaddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhaddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhsub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhsub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uhsubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV umaal(void** buf, Condition cond);
void CALLCONV umlal(void** buf, Condition cond, bool s);
void CALLCONV umull(void** buf, Condition cond, bool s);
void CALLCONV uqadd16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uqadd8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uqaddsubx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uqsub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uqsub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uqsubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV usad8(void** buf, Condition cond, Reg rd);
void CALLCONV usada8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV usat(void** buf, Condition cond, Reg rd);
void CALLCONV usat16(void** buf, Condition cond, Reg rd);
void CALLCONV usub16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV usub8(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV usubaddx(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uxtab(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uxtab16(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uxtah(void** buf, Condition cond, Reg rn, Reg rd);
void CALLCONV uxtb(void** buf, Condition cond, Reg rd);
void CALLCONV uxtb16(void** buf, Condition cond, Reg rd);
void CALLCONV uxth(void** buf, Condition cond, Reg rd);

#define r0 0x0
#define r1 0x1
#define r2 0x2
#define r3 0x3
#define r4 0x4
#define r5 0x5
#define r6 0x6
#define r7 0x7
#define r8 0x8
#define r9 0x9
#define r10 0xa
#define r11 0xb
#define r12 0xc
#define r13 0xd
#define r14 0xe
#define r15 0xf
#define a1 0x0
#define a2 0x1
#define a3 0x2
#define a4 0x3
#define v1 0x4
#define v2 0x5
#define v3 0x6
#define v4 0x7
#define v5 0x8
#define v6 0x9
#define v7 0xa
#define v8 0xb
#define ip 0xc
#define sp 0xd
#define lr 0xe
#define pc 0xf
#define wr 0x7
#define sb 0x9
#define sl 0xa
#define fp 0xb
