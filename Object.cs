using System;
namespace Bot {
    public class Object {

        private int Height{ get; set;}
        private int Width{ get; set;}

        private int PositionX {set; get;}

        private int PositionY {set; get;}
        public Object(){
            {
                Height = 0;
            }
            {
                Width = 0;
            }
        }

        public Object(int height, int width){
            {
                Height = height;
            }
            {
                Width = width;
            }
        }

        public int GetHeight(){ return Height; }
        public int GetWidth(){ return Width; }

        public void SetHeight(int height){ Height = height;}

        public void SetWidth(int width){ Width = width; }

        public void SetPosition(int x, int y){ PositionX = x; PositionY = y;}

        public void SetPositionX(int x){PositionX = x;}

        public void SetPositionY(int y){PositionY = y;}

        public int GetPositionX(){ return PositionX;}

        public int GetPositionY(){ return PositionY;}
   }   
}
