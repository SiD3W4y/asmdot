from cffi import FFI

ffi = FFI()

ffi.cdef("int arm_adc(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_add(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_and(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_eor(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_orr(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_rsb(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_rsc(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_sbc(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_sub(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_bkpt(void**);")
ffi.cdef("int arm_b(condition, void**);")
ffi.cdef("int arm_bic(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_blx(condition, void**);")
ffi.cdef("int arm_bx(condition, void**);")
ffi.cdef("int arm_bxj(condition, void**);")
ffi.cdef("int arm_blxun(void**);")
ffi.cdef("int arm_cdp(condition, void**);")
ffi.cdef("int arm_clz(condition, reg, void**);")
ffi.cdef("int arm_cmn(condition, bool, reg, void**);")
ffi.cdef("int arm_cmp(condition, bool, reg, void**);")
ffi.cdef("int arm_cpy(condition, reg, void**);")
ffi.cdef("int arm_cps(Mode, void**);")
ffi.cdef("int arm_cpsie(void**);")
ffi.cdef("int arm_cpsid(void**);")
ffi.cdef("int arm_cpsie_mode(Mode, void**);")
ffi.cdef("int arm_cpsid_mode(Mode, void**);")
ffi.cdef("int arm_ldc(condition, bool, reg, void**);")
ffi.cdef("int arm_ldm1(condition, bool, reg, void**);")
ffi.cdef("int arm_ldm2(condition, reg, void**);")
ffi.cdef("int arm_ldm3(condition, bool, reg, void**);")
ffi.cdef("int arm_ldr(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrb(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrbt(condition, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrd(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrex(condition, reg, reg, void**);")
ffi.cdef("int arm_ldrh(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrsb(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrsh(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_ldrt(condition, bool, reg, reg, void**);")
ffi.cdef("int arm_mcr(condition, reg, void**);")
ffi.cdef("int arm_mcrr(condition, reg, reg, void**);")
ffi.cdef("int arm_mla(condition, bool, reg, reg, void**);")
ffi.cdef("int arm_mov(condition, bool, bool, reg, void**);")
ffi.cdef("int arm_mrc(condition, reg, void**);")
ffi.cdef("int arm_mrrc(condition, reg, reg, void**);")
ffi.cdef("int arm_mrs(condition, reg, void**);")
ffi.cdef("int arm_mul(condition, bool, reg, void**);")
ffi.cdef("int arm_mvn(condition, bool, bool, reg, void**);")
ffi.cdef("int arm_msr_imm(condition, void**);")
ffi.cdef("int arm_msr_reg(condition, void**);")
ffi.cdef("int arm_pkhbt(condition, reg, reg, void**);")
ffi.cdef("int arm_pkhtb(condition, reg, reg, void**);")
ffi.cdef("int arm_pld(bool, reg, void**);")
ffi.cdef("int arm_qadd(condition, reg, reg, void**);")
ffi.cdef("int arm_qadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_qadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_qaddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_qdadd(condition, reg, reg, void**);")
ffi.cdef("int arm_qdsub(condition, reg, reg, void**);")
ffi.cdef("int arm_qsub(condition, reg, reg, void**);")
ffi.cdef("int arm_qsub16(condition, reg, reg, void**);")
ffi.cdef("int arm_qsub8(condition, reg, reg, void**);")
ffi.cdef("int arm_qsubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_rev(condition, reg, void**);")
ffi.cdef("int arm_rev16(condition, reg, void**);")
ffi.cdef("int arm_revsh(condition, reg, void**);")
ffi.cdef("int arm_rfe(bool, reg, void**);")
ffi.cdef("int arm_sadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_sadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_saddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_sel(condition, reg, reg, void**);")
ffi.cdef("int arm_setendbe(void**);")
ffi.cdef("int arm_setendle(void**);")
ffi.cdef("int arm_shadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_shadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_shaddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_shsub16(condition, reg, reg, void**);")
ffi.cdef("int arm_shsub8(condition, reg, reg, void**);")
ffi.cdef("int arm_shsubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_smlabb(condition, reg, reg, void**);")
ffi.cdef("int arm_smlabt(condition, reg, reg, void**);")
ffi.cdef("int arm_smlatb(condition, reg, reg, void**);")
ffi.cdef("int arm_smlatt(condition, reg, reg, void**);")
ffi.cdef("int arm_smlad(condition, reg, reg, void**);")
ffi.cdef("int arm_smlal(condition, bool, void**);")
ffi.cdef("int arm_smlalbb(condition, void**);")
ffi.cdef("int arm_smlalbt(condition, void**);")
ffi.cdef("int arm_smlaltb(condition, void**);")
ffi.cdef("int arm_smlaltt(condition, void**);")
ffi.cdef("int arm_smlald(condition, void**);")
ffi.cdef("int arm_smlawb(condition, reg, reg, void**);")
ffi.cdef("int arm_smlawt(condition, reg, reg, void**);")
ffi.cdef("int arm_smlsd(condition, reg, reg, void**);")
ffi.cdef("int arm_smlsld(condition, void**);")
ffi.cdef("int arm_smmla(condition, reg, reg, void**);")
ffi.cdef("int arm_smmls(condition, reg, reg, void**);")
ffi.cdef("int arm_smmul(condition, reg, void**);")
ffi.cdef("int arm_smuad(condition, reg, void**);")
ffi.cdef("int arm_smulbb(condition, reg, void**);")
ffi.cdef("int arm_smulbt(condition, reg, void**);")
ffi.cdef("int arm_smultb(condition, reg, void**);")
ffi.cdef("int arm_smultt(condition, reg, void**);")
ffi.cdef("int arm_smull(condition, bool, void**);")
ffi.cdef("int arm_smulwb(condition, reg, void**);")
ffi.cdef("int arm_smulwt(condition, reg, void**);")
ffi.cdef("int arm_smusd(condition, reg, void**);")
ffi.cdef("int arm_srs(bool, Mode, void**);")
ffi.cdef("int arm_ssat(condition, reg, void**);")
ffi.cdef("int arm_ssat16(condition, reg, void**);")
ffi.cdef("int arm_ssub16(condition, reg, reg, void**);")
ffi.cdef("int arm_ssub8(condition, reg, reg, void**);")
ffi.cdef("int arm_ssubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_stc(condition, bool, reg, void**);")
ffi.cdef("int arm_stm1(condition, bool, reg, void**);")
ffi.cdef("int arm_stm2(condition, reg, void**);")
ffi.cdef("int arm_str(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_strb(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_strbt(condition, bool, reg, reg, void**);")
ffi.cdef("int arm_strd(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_strex(condition, reg, reg, void**);")
ffi.cdef("int arm_strh(condition, bool, bool, reg, reg, void**);")
ffi.cdef("int arm_strt(condition, bool, reg, reg, void**);")
ffi.cdef("int arm_swi(condition, void**);")
ffi.cdef("int arm_swp(condition, reg, reg, void**);")
ffi.cdef("int arm_swpb(condition, reg, reg, void**);")
ffi.cdef("int arm_sxtab(condition, reg, reg, void**);")
ffi.cdef("int arm_sxtab16(condition, reg, reg, void**);")
ffi.cdef("int arm_sxtah(condition, reg, reg, void**);")
ffi.cdef("int arm_sxtb(condition, reg, void**);")
ffi.cdef("int arm_sxtb16(condition, reg, void**);")
ffi.cdef("int arm_sxth(condition, reg, void**);")
ffi.cdef("int arm_teq(condition, bool, reg, void**);")
ffi.cdef("int arm_tst(condition, bool, reg, void**);")
ffi.cdef("int arm_uadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_uadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_uaddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_uhadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_uhadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_uhaddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_uhsub16(condition, reg, reg, void**);")
ffi.cdef("int arm_uhsub8(condition, reg, reg, void**);")
ffi.cdef("int arm_uhsubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_umaal(condition, void**);")
ffi.cdef("int arm_umlal(condition, bool, void**);")
ffi.cdef("int arm_umull(condition, bool, void**);")
ffi.cdef("int arm_uqadd16(condition, reg, reg, void**);")
ffi.cdef("int arm_uqadd8(condition, reg, reg, void**);")
ffi.cdef("int arm_uqaddsubx(condition, reg, reg, void**);")
ffi.cdef("int arm_uqsub16(condition, reg, reg, void**);")
ffi.cdef("int arm_uqsub8(condition, reg, reg, void**);")
ffi.cdef("int arm_uqsubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_usad8(condition, reg, void**);")
ffi.cdef("int arm_usada8(condition, reg, reg, void**);")
ffi.cdef("int arm_usat(condition, reg, void**);")
ffi.cdef("int arm_usat16(condition, reg, void**);")
ffi.cdef("int arm_usub16(condition, reg, reg, void**);")
ffi.cdef("int arm_usub8(condition, reg, reg, void**);")
ffi.cdef("int arm_usubaddx(condition, reg, reg, void**);")
ffi.cdef("int arm_uxtab(condition, reg, reg, void**);")
ffi.cdef("int arm_uxtab16(condition, reg, reg, void**);")
ffi.cdef("int arm_uxtah(condition, reg, reg, void**);")
ffi.cdef("int arm_uxtb(condition, reg, void**);")
ffi.cdef("int arm_uxtb16(condition, reg, void**);")
ffi.cdef("int arm_uxth(condition, reg, void**);")