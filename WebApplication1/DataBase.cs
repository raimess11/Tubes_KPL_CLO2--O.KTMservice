using System.Runtime.CompilerServices;

namespace DBServerAPI
{
    public class DataBase
    {
        /*
            State-based method
            referensi PPT Pertemuan-3 KPL slide 25-31
        */
        public enum State
        {
            Verifikasi,
            BelumMulai,
            Gagal,
            Mulai,
            BisaAbsen,
            BisaAksesFasilitas,
            Selesai
        }
        public enum Trigger
        {
            BerhasilVerifikasi,
            GagalVerifikasi,
            Mulai,
            BisaAbsen,
            BisaAksesFasilitas,
            Selesai
        }

        private State StatePengurusan;

        string[] kondisiKTM =
        {
            "Verifikasi Dokumen Request",
            "Dokumen tidak diterima", 
            "Pengurusan KTM siap dimulai", 
            "Proses pengurusan KTM sedang berjalan", 
            "KTM sudah bisa digunakan untuk absen", 
            "KTM sudah bisa digunakan untuk fasilitas kampus", 
            "Proses sudah selesai",
        };

        public class transtion
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public transtion(State prevState,State nextState,Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transtion[] transitions =
        {
            new transtion(State.Verifikasi,State.BelumMulai,Trigger.BerhasilVerifikasi),
            new transtion(State.Verifikasi,State.Gagal,Trigger.GagalVerifikasi),
            new transtion(State.BelumMulai,State.Mulai,Trigger.Mulai),
            new transtion(State.Mulai,State.BisaAbsen,Trigger.BisaAbsen),
            new transtion(State.Mulai,State.BisaAksesFasilitas,Trigger.BisaAksesFasilitas),
            new transtion(State.BisaAbsen,State.BisaAksesFasilitas,Trigger.BisaAksesFasilitas),
            new transtion(State.BisaAksesFasilitas,State.BisaAbsen,Trigger.BisaAbsen),
            new transtion(State.BisaAbsen,State.Selesai,Trigger.Selesai),
            new transtion(State.BisaAksesFasilitas,State.Selesai,Trigger.Selesai),
        };

        public State getNextState(State prevState, Trigger trigger)
        {
            State nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                {
                    nextState = transitions[i].nextState;
                }
            }
            return nextState;
        }

        public void activateTrigger(Trigger trigger)
        {
            State nextState = getNextState(StatePengurusan, trigger);
            StatePengurusan = nextState;
        }
    }
}
