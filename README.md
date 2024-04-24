# Demonstrate Pos Detail with KryptonDataGridView.
# Visual Basic .Net (2017) & .Net Framework 4.6.2+

### โค้ดชุดนี้ต่อเนื่องมาจากครั้งก่อน https://github.com/thongkorn/DetailDataGridView แต่เปลี่ยนจาก DataGridView ของ Microsoft มาเป็น KryptonDataGridView ของฟรีแทน เพื่อปรับแต่งให้ทั้งฟอร์มและตารางกริดมีความสวยงามมากยิ่งขึ้น รวมไปถึงใส่การคำนวณภาษีให้มาด้วย

##### เสมือนจำลองการทำรายการขายสินค้า แต่ยังไม่มีการเชื่อมต่อกับฐานข้อมูลใดๆ โดยอาศัย DataTable เป็นตารางข้อมูลสมมุติ เพื่อจะได้ไม่พะวงในเรื่องระบบฐานข้อมูลมากเกินไป แต่ให้โฟกัสมาที่ วิธีการคิด และกระบวนการขั้นตอนของการค้นหารายการสินค้า (Flow Control) เพื่อที่จะนำมันมาใส่ไว้ในตารางกริด (DataGridView) โดยยึดตามหลักความเป็นจริงคือ ผู้ใช้งานจะยิงรหัสบาร์โค้ด (ยาวหลายหลัก) จากนั้นเครื่องอ่านจะส่งรหัส ASCII 13 หรือ Enter ปิดท้ายให้ เพื่อไปทำการค้นหาข้อมูลใน DataTable แต่ในการทดสอบเราจะป้อนตัวเลข 01 - 22 ตามด้วย Enter แทน เพื่อให้ง่ายและรวดเร็ว

##### การค้นหาข้อมูล หากพบข้อมูลที่อยู่ในตารางข้อมูล (DataTable) ต่อไปคือต้องวนรอบค้นหาข้อมูลรายการสินค้าที่ต้องการในตารางกริดเสียก่อน หากเจอข้อมูล ก็กำหนดให้จำนวนสินค้าในแถวนั้นๆ เพิ่มขึ้นอีก 1 และกำหนด Flag (หรือ Boolean) บอกให้รู้ว่าเจอแล้ว จะได้ไม่ต้องไปเพิ่มรายการแถวสินค้าเข้าไปใหม่ และกระโดดออกจากการวนรอบในตารางกริด ... พอวนรอบแถวในตารางกริดจนหมด หากหาไม่เจอ ก็ต้องสร้างรายการแถวสินค้าตัวใหม่เข้ามาในตารางกริด โดยอาศัย Flag จากที่กำหนดไว้ก่อนหน้าเป็นเงื่อนไข ... การที่จะทำความเข้าใจในวิธีการขั้นตอนนี้ได้ดี คุณจะต้องนำ Debugger เข้ามาช่วยเหลือด้วยครับ

![poskryptondatagridview](https://github.com/thongkorn/PosKryptonDataGridView/assets/27464308/fa940150-d842-4307-ae2b-86f782479693)
