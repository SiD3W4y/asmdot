from cffi import FFI

ffi = FFI()

ffi.cdef("bool adc(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool add(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool and(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool eor(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool orr(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool rsb(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool rsc(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool sbc(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool sub(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool bkpt(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool b(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool bic(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool blx(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool bx(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool bxj(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool blxun(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool cdp(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool clz(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool cmn(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool cmp(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool cpy(condition, bool, bool, reg, reg, void*);")
ffi.cdef("bool cps(condition, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool cpsie(condition, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool cpsid(condition, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool cpsie_mode(condition, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool cpsid_mode(condition, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldc(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldm1(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldm2(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldm3(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldr(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrbt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrex(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrh(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrsb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrsh(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ldrt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mcr(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mcrr(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mla(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mov(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mrc(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mrrc(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mrs(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mul(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool mvn(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool msr_imm(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool msr_reg(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool pkhbt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool pkhtb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool pld(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qadd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qaddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qdadd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qdsub(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qsub(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qsub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qsub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool qsubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool rev(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool rev16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool revsh(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool rfe(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool saddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sel(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool setendbe(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool setendle(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shaddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shsub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shsub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool shsubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlabb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlabt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlatb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlatt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlad(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlal(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlalbb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlalbt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlaltb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlaltt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlald(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlawb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlawt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlsd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smlsld(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smmla(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smmls(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smmul(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smuad(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smulbb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smulbt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smultb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smultt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smull(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smulwb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smulwt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool smusd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool srs(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ssat(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ssat16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ssub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ssub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool ssubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool stc(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool stm1(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool stm2(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool str(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strbt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strd(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strex(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strh(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool strt(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool swi(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool swp(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool swpb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxtab(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxtab16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxtah(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxtb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxtb16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool sxth(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool teq(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool tst(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uaddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhaddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhsub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhsub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uhsubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool umaal(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool umlal(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool umull(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqadd16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqadd8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqaddsubx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqsub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqsub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uqsubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usad8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usada8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usat(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usat16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usub16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usub8(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool usubaddx(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxtab(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxtab16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxtah(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxtb(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxtb16(condition, bool, bool, bool, reg, reg, Mode, void*);")
ffi.cdef("bool uxth(condition, bool, bool, bool, reg, reg, Mode, void*);")