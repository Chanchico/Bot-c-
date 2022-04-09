namespace Bot {
    public class Cube : Object{

        public Cube(){ }
       
        public Cube(int height, int width, int position_x, int position_y) {
            this.SetHeight(height);
            this.SetWidth(width);
            this.SetPosition(position_x, position_y);
        }
    }
}