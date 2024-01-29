import {
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  input,
} from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  constructor(
    private accountService: AccountService,
    private toaster: ToastrService
  ) {}

  ngOnInit(): void {}
  register() {
    this.accountService.register(this.model).subscribe({
      next: () => {
        this.cancel();
      },
      error: (error) => this.toaster.error(error.error),
    });
  }
  cancel() {
    this.cancelRegister.emit(false);
  }
}
